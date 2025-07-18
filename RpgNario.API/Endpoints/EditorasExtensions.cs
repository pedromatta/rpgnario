using RpgNario.API.Response;
using RpgNario.API.Requests;
using RpgNario.Banco;
using RpgNario.Modelos;
using Microsoft.AspNetCore.Mvc;
namespace RpgNario.API.Endpoints;

public static class EditorasExtensions
{
    public static void AddEndpointsEditoras(this WebApplication app)
    {
        var groupBuilder = app.MapGroup("editoras").RequireAuthorization().WithTags("Editoras");

        groupBuilder.MapGet("", ([FromServices] DAL<Editora> dal) =>
        {
            var editoras = dal.Listar();
            if (editoras is null)
            {
                return Results.NotFound();
            }
            var editorasResponse = EntityListToResponseList(editoras);
            return Results.Ok(editorasResponse);
        });

        groupBuilder.MapGet("{nome}", ([FromServices] DAL<Editora> dal, string nome) =>
        {
            var editora = dal.RecuperarPor(e => e.Nome.ToUpper().Equals(nome.ToUpper()));
            if (editora is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(EntityToResponse(editora));
        });

        groupBuilder.MapPost("", async ([FromServices] IHostEnvironment env, [FromServices] DAL<Editora> dal, [FromBody] EditoraRequest editoraRequest) =>
        {
            var nome = editoraRequest.Nome.Replace(" ", "_");
            var imagemEditora = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "FotosEditora", imagemEditora);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(editoraRequest.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            var editora = new Editora(editoraRequest.Nome, editoraRequest.Tipo, editoraRequest.SiteOficial)
            {
                Foto = $"/FotosEditora/{imagemEditora}"
            };

            dal.Adicionar(editora);
            return Results.Ok();
        });

        groupBuilder.MapDelete("{id}", ([FromServices] DAL<Editora> dal, int id) =>
        {
            var editora = dal.RecuperarPor(e => e.Id == id);
            if (editora is null)
            {
                return Results.NotFound();
            }

            dal.Deletar(editora);
            return Results.NoContent();
        });

        groupBuilder.MapPut("", async ([FromServices] IHostEnvironment env, [FromServices] DAL<Editora> dal, [FromBody] EditoraRequestEdit editoraRequestEdit) =>
        {
            var nome = editoraRequestEdit.Nome.Replace(" ", "_");
            var imagemEditora = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "FotosEditora", imagemEditora);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(editoraRequestEdit.Foto!));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            var editoraAtualizar = dal.RecuperarPor(e => e.Id == editoraRequestEdit.Id);

            if (editoraAtualizar is null)
            {
                return Results.NotFound();
            }

            editoraAtualizar.Nome = editoraRequestEdit.Nome;
            editoraAtualizar.Tipo = editoraRequestEdit.Tipo;
            editoraAtualizar.SiteOficial = editoraRequestEdit.SiteOficial;
            editoraAtualizar.Foto = $"/FotosEditora/{imagemEditora}";

            dal.Atualizar(editoraAtualizar);
            return Results.Ok();
        });
    }

    private static ICollection<EditoraResponse> EntityListToResponseList(IEnumerable<Editora> editoras)
    {
        return editoras.Select(e => EntityToResponse(e)).ToList();
    }

    private static EditoraResponse EntityToResponse(Editora editora)
    {
        return new EditoraResponse(editora.Id, editora.Nome, editora.Tipo, editora.SiteOficial, editora.Foto);
    }
}
