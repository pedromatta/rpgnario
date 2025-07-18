using RpgNario.Modelos;
using RpgNario.Banco;

namespace RpgNario.Menus;

internal class MenuRegistrarSistema : Menu
{
    public override void Executar(DAL<Editora> editoraDAL)
    {
        base.Executar(editoraDAL);
        ExibirTituloDaOpcao("Registro de sistemas");

        Console.Write("Digite a editora cujo sistema deseja registrar: ");
        string nomeDaEditora = Console.ReadLine()!;

        var editoraRecuperada = editoraDAL.RecuperarPor(a => a.Nome.Equals(nomeDaEditora));

        if (editoraRecuperada is not null)
        {
            Console.Write("Agora digite o título do sistema: ");
            string tituloDoSistema = Console.ReadLine()!;
            Console.Write("Digite o link para o sistema: ");
            string linkDoSistema = Console.ReadLine()!;
            Console.Write("Digite a descrição do sistema: ");
            string descricaoDoSistema = Console.ReadLine()!;
            Console.Write("Digite a engine do sistema: ");
            string engineDoSistema = Console.ReadLine()!;
            Console.Write("Digite o ano de lançamento do sistema");
            int anoDoSistema = int.Parse(Console.ReadLine()!);

            var sistema = new Sistema(tituloDoSistema, linkDoSistema, descricaoDoSistema, anoDoSistema);
            if (!string.IsNullOrWhiteSpace(engineDoSistema))
            {
                sistema.Engine = engineDoSistema;
            }
            editoraRecuperada.AdicionarSistema(sistema);
            Console.WriteLine($"O sistema {tituloDoSistema} foi registrado com sucesso!");

            editoraDAL.Atualizar(editoraRecuperada);

            Thread.Sleep(4000);
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
