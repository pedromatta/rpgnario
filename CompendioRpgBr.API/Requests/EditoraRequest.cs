using System.ComponentModel.DataAnnotations;

namespace CompendioRpgBr.API.Requests;

public record EditoraRequest([Required] string Nome, [Required] string Tipo, string SiteOficial, string? Foto);
