using CompendioRpgBr.Modelos;
using CompendioRpgBr.Banco;

namespace CompendioRpgBr.Menus;

internal class MenuMostrarSistemas : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        base.Executar(editoraDAL);
        ExibirTituloDaOpcao("Exibir detalhes da editora");
        Console.Write("Digite o nome da editora que deseja conhecer melhor: ");
        string nomeDaEditora = Console.ReadLine()!;
        var editoraRecuperada = editoraDAL.RecuperarPor(a => a.Nome.Equals(nomeDaEditora));
        if (editoraRecuperada is not null)
        {
            Console.WriteLine("\nSistemas:");
            editoraRecuperada.ExibirSistemas();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA editora {nomeDaEditora} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
