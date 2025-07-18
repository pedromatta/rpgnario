namespace RpgNario.API.Requests;

public record SistemaRequestEdit(int Id, string Nome, string Link, string Descricao, string Engine, int AnoLancamento, int EditoraId, string? Foto, ICollection<GeneroRequest>? Generos) : SistemaRequest(Nome, Link, Descricao, Engine, AnoLancamento, EditoraId, Foto, Generos);
