using RpgNario.Modelos;
using RpgNario.Banco;

namespace RpgNario.Menus;

internal class MenuRegistrarEditora : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        base.Executar(editoraDAL);
        ExibirTituloDaOpcao("Registro das Editoras");

        Console.Write("Digite o nome da editora que deseja registrar: ");
        string nomeDaEditora = Console.ReadLine()!;
        Console.Write("Digite o site da editora que deseja registrar: ");
        string tipoDaEditora = Console.ReadLine()!;
        Console.Write("Digite o site da editora que deseja registrar: ");
        string siteDaEditora = Console.ReadLine()!;

        Editora editora = new Editora(nomeDaEditora, tipoDaEditora, siteDaEditora);

        editoraDAL.Adicionar(editora);
        Console.WriteLine($"A editora {nomeDaEditora} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
