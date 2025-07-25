using System.ComponentModel.DataAnnotations;
namespace RpgNario.Web.Requests;

public record SistemaRequest([Required] string Nome, [Required] string Link, [Required] string Descricao, string Engine, [Required] int AnoLancamento, int EditoraId, string? Foto, ICollection<GeneroRequest>? Generos = null);
