using RpgNario.Modelos;
using RpgNario.Banco;

namespace RpgNario.Menus;

internal class MenuMostrarEditoras : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        base.Executar(editoraDAL);
        ExibirTituloDaOpcao("Exibindo todas as editoras registradas na nossa aplicação");

        foreach (var editora in editoraDAL.Listar())
        {
            Console.WriteLine($"Editora: {editora}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
