using CompendioRpgBr.API.Response;
using CompendioRpgBr.API.Requests;
using CompendioRpgBr.Banco;
using CompendioRpgBr.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CompendioRpgBr.API.Endpoints;

public static class GenerosExtensions
{
    public static void AddEndPointsGeneros(this WebApplication app)
    {
        app.MapGet("/Generos", ([FromServices] DAL<Genero> dal) =>
        {
            var generos = dal.Listar();
            if (generos is null)
            {
                return Results.NotFound();
            }
            var generosResponse = EntityListToResponseList(generos);
            return Results.Ok(generosResponse);
        });

        app.MapGet("/Generos/{nome}", ([FromServices] DAL<Genero> dal, string nome) =>
        {
            var genero = dal.RecuperarPor(g => g.Nome.ToUpper().Equals(nome.ToUpper()));
            if (genero is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(EntityToResponse(genero));
        });

        app.MapGet("/Generos/Sistema/{nomeSistema}", ([FromServices] DAL<Genero> dal, [FromServices] DAL<Sistema> dalSistema, string nomeSistema) =>
        {
            var sistema = dalSistema.RecuperarPor(s => s.Nome.ToUpper().Equals(nomeSistema.ToUpper()));
            var generos = dal.Listar();
            if (generos is null || sistema is null)
            {
                return Results.NotFound();
            }

            var generosDoSistema = generos.Where(g => sistema.Generos!.Contains(g));

            var generosResponse = EntityListToResponseList(generosDoSistema);
            return Results.Ok(generosResponse);
        });

        app.MapPost("/Generos", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequest generoRequest) =>
        {
            var genero = new Genero()
            {
                Nome = generoRequest.Nome,
                Descricao = generoRequest.Descricao
            };
            dal.Adicionar(genero);
            return Results.Ok();
        });

        app.MapDelete("/Generos/{id}", ([FromServices] DAL<Genero> dal, int id) =>
        {
            var genero = dal.RecuperarPor(g => g.Id == id);
            if (genero is null)
            {
                return Results.NotFound();
            }

            dal.Deletar(genero);
            return Results.NoContent();
        });

        app.MapPut("/Generos", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequestEdit generoRequestEdit) =>
        {
            var generoAtualizar = dal.RecuperarPor(g => g.Id == generoRequestEdit.Id);

            if (generoAtualizar is null)
            {
                return Results.NotFound();
            }

            generoAtualizar.Nome = generoRequestEdit.Nome;
            generoAtualizar.Descricao = generoRequestEdit.Descricao;

            dal.Atualizar(generoAtualizar);
            return Results.Ok();
        });
    }

    private static Genero RequestToEntity(GeneroRequest genero)
    {
        return new Genero() { Nome = genero.Nome, Descricao = genero.Descricao };
    }

    private static ICollection<GeneroResponse> EntityListToResponseList(IEnumerable<Genero> generos)
    {
        return generos.Select(g => EntityToResponse(g)).ToList();
    }

    private static GeneroResponse EntityToResponse(Genero generos)
    {
        return new GeneroResponse(generos.Id, generos.Nome, generos.Descricao ?? "Descrição não informada");
    }
}
