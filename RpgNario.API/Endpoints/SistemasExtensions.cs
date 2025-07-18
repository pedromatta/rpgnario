using RpgNario.API.Response;
using RpgNario.API.Requests;
using RpgNario.Banco;
using RpgNario.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace RpgNario.API.Endpoints;

public static class SistemasExtensions
{
    public static void AddEndPointsSistemas(this WebApplication app)
    {
        var groupBuilder = app.MapGroup("sistemas").RequireAuthorization().WithTags("Sistemas");

        groupBuilder.MapGet("", ([FromServices] DAL<Sistema> dal) =>
        {
            var sistemas = dal.Listar();
            if (sistemas is null)
            {
                return Results.NotFound();
            }
            var sistemasResponse = EntityListToResponseList(sistemas);
            return Results.Ok(sistemasResponse);
        });

        groupBuilder.MapGet("{nome}", ([FromServices] DAL<Sistema> dal, string nome) =>
        {
            var sistema = dal.RecuperarPor(s => s.Nome.ToUpper().Equals(nome.ToUpper()));
            if (sistema is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(EntityToResponse(sistema));
        });

        groupBuilder.MapGet("Editora/{nomeEditora}", ([FromServices] DAL<Sistema> dal, string nomeEditora) =>
        {
            var sistemas = dal.Listar();
            if (sistemas is null)
            {
                return Results.NotFound();
            }

            var sistemasDaEditora = sistemas.Where(s => s.Editora!.Nome.ToUpper().Equals(nomeEditora.ToUpper())).ToList();
            if (sistemasDaEditora is null)
            {
                return Results.NotFound();
            }

            var sistemasResponse = EntityListToResponseList(sistemasDaEditora);
            return Results.Ok(sistemasResponse);
        });

        groupBuilder.MapGet("Genero/{nomeGenero}", ([FromServices] DAL<Sistema> dal, string nomeGenero) =>
        {
            var sistemas = dal.Listar();
            if (sistemas is null)
            {
                return Results.NotFound();
            }

            var sistemasComOGenero = sistemas.Where(s => s.Generos is not null && s.Generos.Any(g => g.Nome.ToUpper().Equals(nomeGenero.ToUpper())));

            var sistemasResponse = EntityListToResponseList(sistemasComOGenero);
            return Results.Ok(sistemasResponse);
        });

        groupBuilder.MapPost("", async ([FromServices] IHostEnvironment env, [FromServices] DAL<Sistema> dal, [FromServices] DAL<Genero> generoDal, [FromBody] SistemaRequest sistemaRequest) =>
        {
            var nome = sistemaRequest.Nome.Replace(" ", "_");
            var imagemSistema = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "FotosSistema", imagemSistema);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(sistemaRequest.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            var sistema = new Sistema(sistemaRequest.Nome, sistemaRequest.Link, sistemaRequest.Descricao, sistemaRequest.AnoLancamento)
            {
                EditoraId = sistemaRequest.EditoraId,
                Engine = sistemaRequest.Engine,
                Generos = sistemaRequest.Generos is not null ?
                GeneroRequestConverter(sistemaRequest.Generos, generoDal) :
                new List<Genero>(),
                Foto = $"/FotosSistema/{imagemSistema}"
            };

            dal.Adicionar(sistema);
            return Results.Ok();
        });

        groupBuilder.MapDelete("{id}", ([FromServices] DAL<Sistema> dal, int id) =>
        {
            var sistema = dal.RecuperarPor(s => s.Id == id);
            if (sistema is null)
            {
                return Results.NotFound();
            }

            dal.Deletar(sistema);
            return Results.NoContent();
        });

        groupBuilder.MapPut("", async ([FromServices] IHostEnvironment env, [FromServices] DAL<Sistema> dal, [FromServices] DAL<Genero> generoDal, [FromBody] SistemaRequestEdit sistemaRequestEdit) =>
        {
            var nome = sistemaRequestEdit.Nome.Replace(" ", "_");
            var imagemSistema = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "FotosSistema", imagemSistema);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(sistemaRequestEdit.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            var sistemaAtualizar = dal.RecuperarPor(s => s.Id == sistemaRequestEdit.Id);

            if (sistemaAtualizar is null)
            {
                return Results.NotFound();
            }

            sistemaAtualizar.Nome = sistemaRequestEdit.Nome;
            sistemaAtualizar.Link = sistemaRequestEdit.Link;
            sistemaAtualizar.Descricao = sistemaRequestEdit.Descricao;
            sistemaAtualizar.Engine = sistemaRequestEdit.Engine;
            sistemaAtualizar.AnoLancamento = sistemaRequestEdit.AnoLancamento;
            sistemaAtualizar.Foto = $"/FotosSistema/{imagemSistema}";

            if (sistemaRequestEdit.Generos is not null)
            {
                sistemaAtualizar.Generos = GeneroRequestConverter(sistemaRequestEdit.Generos, generoDal);
            }

            dal.Atualizar(sistemaAtualizar);
            return Results.Ok();
        });

    }

    private static ICollection<Genero> GeneroRequestConverter(ICollection<GeneroRequest> generos, DAL<Genero> generoDal)
    {
        var listaGeneros = new List<Genero>();

        foreach (var genero in generos)
        {
            var entity = RequestToEntity(genero);
            var generoRegistrado = generoDal.RecuperarPor(g => g.Nome.ToUpper().Equals(genero.Nome.ToUpper()));

            if (generoRegistrado is not null)
            {
                listaGeneros.Add(generoRegistrado);
            }
            else
            {
                listaGeneros.Add(entity);
            }
        }

        return listaGeneros;
    }

    private static Genero RequestToEntity(GeneroRequest genero)
    {
        return new Genero() { Nome = genero.Nome, Descricao = genero.Descricao };
    }

    private static ICollection<SistemaResponse> EntityListToResponseList(IEnumerable<Sistema> sistemas)
    {
        return sistemas.Select(s => EntityToResponse(s)).ToList();
    }

    private static SistemaResponse EntityToResponse(Sistema sistema)
    {
        var generos = sistema.Generos is null ? new List<string>() : sistema.Generos.Select(g => g.Nome).ToList();
        return new SistemaResponse(sistema.Id, sistema.Nome, sistema.Link, sistema.Descricao, sistema.Engine ?? "Não especificada", sistema.AnoLancamento, sistema.Editora!.Id, sistema.Editora!.Nome, sistema.Foto ?? "", generos);
    }
}
