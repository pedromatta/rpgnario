using System.ComponentModel.DataAnnotations;

namespace RpgNario.API.Requests;

public record EditoraRequest([Required] string Nome, [Required] string Tipo, string SiteOficial, string? Foto);
