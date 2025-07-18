namespace RpgNario.Web.Response;

public record EditoraResponse(int Id, string Nome, string Tipo, string SiteOficial, string? Foto)
{
    public override string ToString()
    {
        return $"{this.Nome}";
    }
}
