using RpgNario.Modelos;
using RpgNario.Banco;

namespace RpgNario.Menus;

internal class MenuSair : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
