namespace CompendioRpgBr.API.Response;

public record EditoraResponse(int Id, string Nome, string Tipo, string SiteOficial, string? Foto = "");
