namespace CompendioRpgBr.Web.Response;

public record SistemaResponse(int Id, string Nome, string Link, string Descricao, string Engine, int AnoLancamento, int EditoraId, string NomeEditora, string? Foto, List<string>? GenerosNomes);
