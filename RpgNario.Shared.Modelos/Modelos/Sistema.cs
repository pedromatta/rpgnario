namespace RpgNario.Modelos;

public class Sistema
{
    public Sistema(string nome, string link, string descricao, int anoLancamento)
    {
        Nome = nome;
        Link = link;
        Descricao = descricao;
        AnoLancamento = anoLancamento;
    }

    public int Id { get; set; }
    public int AnoLancamento { get; set; }

    public string Nome { get; set; }
    public string Link { get; set; }
    public string Descricao { get; set; }

    public string? Engine { get; set; }
    public string? Foto { get; set; }
    public int? EditoraId { get; set; }
    public virtual Editora? Editora { get; set; }
    public virtual ICollection<Genero>? Generos { get; set; }
    public virtual ICollection<AvaliacaoSistema> Avaliacoes { get; set; } = new List<AvaliacaoSistema>();

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($@"Nome: {Nome}
                Link: {Link}
                Descrição: {Descricao}
                Engine: {Engine}
                Ano de Lançamento: {AnoLancamento}");

    }

    public void AdicionarNota(int pessoaId, int nota)
    {
        nota = Math.Clamp(nota, 1, 5);

        Avaliacoes.Add(new AvaliacaoSistema()
        {
            SistemaId = this.Id,
            PessoaId = pessoaId,
            Nota = nota
        });
    }

    public override string ToString()
    {
        return $@"Id: {Id}
                Nome: {Nome}
                Link: {Link}
                Descrição: {Descricao}
                Engine: {Engine}
                Ano de Lançamento: {AnoLancamento}";
    }
}
