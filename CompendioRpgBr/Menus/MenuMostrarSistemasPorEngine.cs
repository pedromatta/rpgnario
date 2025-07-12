using CompendioRpgBr.Banco;
using CompendioRpgBr.Modelos;

namespace CompendioRpgBr.Menus;
internal class MenuMostrarSistemasPorEngine : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        base.Executar(editoraDAL);
        ExibirTituloDaOpcao("Mostrar sistemas por engine");
        Console.Write("Digite a engine para consultar sistemas: ");
        string nomeEngine = Console.ReadLine()!;

        var sistemaDAL = new DAL<Sistema>(new CompendioRpgBrContext());
        var listaEngine = sistemaDAL.ListarPor(a => a.Engine.Equals(nomeEngine));

        if (listaEngine.Any())
        {
            Console.WriteLine($"\nSistemas {nomeEngine}");
            foreach (var sistema in listaEngine)
            {
                sistema.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nNenhum sistema encontrado com a engine {nomeEngine}.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
