namespace RpgNario.API.Response;

public record SistemaResponse(int Id, string Nome, string Link, string Descricao, string Engine, int AnoLancamento, int EditoraId, string NomeEditora, string? Foto, List<string> GenerosNomes) 
{
    public double? Classificacao { get; set; }
};
