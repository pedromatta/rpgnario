namespace RpgNario.Modelos;

public class AvaliacaoSistema
{
    public int SistemaId { get; set; }
    public virtual Sistema? Sistema { get; set; }
    public int PessoaId { get; set; }
    public int Nota { get; set; }
}
