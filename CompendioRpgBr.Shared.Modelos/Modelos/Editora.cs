namespace CompendioRpgBr.Modelos;

public class Editora
{
    private ICollection<Sistema> Sistemas { get; set; } = new List<Sistema>();

    public Editora(string nome, string tipo, string siteOficial)
    {
        Nome = nome;
        Tipo = tipo;
        SiteOficial = siteOficial;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public string SiteOficial { get; set; }
    public string Foto { get; set; } = "";

    public void AdicionarSistema(Sistema sistema)
    {
        Sistemas.Add(sistema);
    }

    public void ExibirSistemas()
    {
        Console.WriteLine($"Sistemas da editora: {Nome}");
        foreach (var sistema in Sistemas)
        {
            Console.WriteLine($"Sistema: {sistema.Nome}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Nome}
            Tipo: {Tipo}
            Site Oficial: {SiteOficial}";
    }
}
