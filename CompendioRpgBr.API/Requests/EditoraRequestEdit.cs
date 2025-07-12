namespace CompendioRpgBr.API.Requests;

public record EditoraRequestEdit(int Id, string Nome, string Tipo, string SiteOficial, string? Foto) : EditoraRequest(Nome, Tipo, SiteOficial, Foto);
