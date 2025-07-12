using CompendioRpgBr.Modelos;
using CompendioRpgBr.Banco;

namespace CompendioRpgBr.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
