using Microsoft.EntityFrameworkCore;
using RpgNario.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RpgNario.Shared.Dados.Modelos;

namespace RpgNario.Banco;
public class RpgNarioContext : IdentityDbContext<PessoaComAcesso, PerfilDeAcesso, int>
{
    public required DbSet<Editora> Editoras { get; set; }
    public required DbSet<Sistema> Sistemas { get; set; }
    public required DbSet<Genero> Generos { get; set; }

    private string connectionString = "Server=localhost;port=3306;database=compendio_rpg_br;User=api_user;Password=insira-senha-forte;";

    public RpgNarioContext(){}

    public RpgNarioContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }
        optionsBuilder
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Editora>().HasData(
            new Editora("Independente", "Agregador", "#") { Id = 1, Foto = "/FotosEditoras/Independente.jpg" },
            new Editora("Jambô", "Editora", "https://jamboeditora.com.br") { Id = 2, Foto = "/FotosEditoras/Jambo.jpg" },
            new Editora("Coisinha Verde", "Editora", "https://coisinhaverde.com.br/jogos/") { Id = 3, Foto = "/FotosEditoras/Coisinha_Verde.jpg" },
            new Editora("New Order", "Editora", "https://newordereditora.com/") { Id = 4, Foto = "/FotosEditoras/New_Order.jpg" },
            new Editora("Lampião Game Studio", "Estúdio Independente", "https://lampiaogamestudio.wordpress.com/") { Id = 5, Foto = "/FotosEditoras/Lampiao_Game_Studio.jpg" },
            new Editora("101 Games", "Estúdio Independente", "https://www.101games.com.br/") { Id = 6, Foto = "/FotosEditoras/101_Games.jpg" },
            new Editora("Buró", "Editora", "https://www.burobrasil.com/") { Id = 7, Foto = "/FotosEditoras/Buro.jpg" },
            new Editora("Editora Draco", "Editora", "https://editoradraco.com/") { Id = 8, Foto = "/FotosEditoras/Editora_Draco.jpg" },
            new Editora("Secular Games", "Coletivo de Autores Independentes", "https://www.seculargames.com.br/") { Id = 9, Foto = "/FotosEditoras/Secular_Games.jpg" }
        );

        modelBuilder.Entity<Genero>().HasData(
            new Genero { Id = 1, Nome = "Fantasia Medieval", Descricao = "Magia, espadas, reinos, monstros, e aventuras em mundos inspirados na Idade Média." },
            new Genero { Id = 2, Nome = "Aventura", Descricao = "Exploração, desafios, perigos, recompensas." },
            new Genero { Id = 3, Nome = "Fantasia", Descricao = "Magia, criaturas místicas, heróis épicos." },
            new Genero { Id = 4, Nome = "Terror", Descricao = "Medo, mistério, ameaças sobrenaturais." },
            new Genero { Id = 5, Nome = "Fantasia Urbana", Descricao = "Magia oculta no mundo moderno." },
            new Genero { Id = 6, Nome = "Anime", Descricao = "Estilo visual marcante, ação exagerada, drama." },
            new Genero { Id = 7, Nome = "Old School", Descricao = "Regras clássicas, letalidade, minimalismo." },
            new Genero { Id = 8, Nome = "Velho-Oeste", Descricao = "Faroeste, duelos, foras-da-lei, deserto." },
            new Genero { Id = 9, Nome = "Cyberpunk", Descricao = "Futuro sombrio, neon, hackers, corporações." },
            new Genero { Id = 10, Nome = "Comédia", Descricao = "Humor, situações absurdas, leveza." },
            new Genero { Id = 11, Nome = "Solo RPG", Descricao = "Aventuras individuais, narrativa pessoal." },
            new Genero { Id = 12, Nome = "Investigativo", Descricao = "Mistérios, pistas, dedução, conspirações." },
            new Genero { Id = 13, Nome = "Ficção Científica", Descricao = "Tecnologia avançada, viagens espaciais." },
            new Genero { Id = 14, Nome = "Sobrevivência", Descricao = "Recursos escassos, perigo constante." }
        );

        modelBuilder.Entity<Sistema>().HasData(
            new Sistema("Tagmar 3", "https://www.tagmar.com.br/", "Terceira edição do primeiro RPG criado por brasileiros. O cenário do Tagmar segue a linha Tolkieniana, ambientada em uma terra de fantásticas raças, poderosas criaturas e incríveis magias, com suas história, folclores e lendas.", 2018) { Id = 1, Engine = "Próprio", EditoraId = 1, Foto = "/FotosSistemas/Tagmar_3.jpg" },
            new Sistema("CBR+PNK", "https://cabinetofcuriosities.games/", "RPG cyberpunk minimalista e premiado, focado em sessões únicas de assaltos de alta tecnologia em um futuro distópico.", 2024) { Id = 2, Engine = "Forged in the Dark", EditoraId = 1, Foto = "/FotosSistemas/CBR_PNK.jpg" },
            new Sistema("Brutal", "https://www.catarse.me/brutal", "RPG de horror que emula filmes slasher dos anos 80, onde jogadores interpretam arquétipos clássicos tentando sobreviver a um assassino implacável.", 2024) { Id = 3, Engine = "Próprio (d6)", EditoraId = 1, Foto = "/FotosSistemas/Brutal.jpg" },
            new Sistema("Arcanas & Ancestrais", "https://clubedeautores.com.br/livro/arcanas-ancestrais", "Dungeon crawler de fantasia sombria e horror, com foco em exploração de masmorras, gerenciamento de sanidade e recursos.", 2020) { Id = 4, Engine = "Híbrido (5e + OSR)", EditoraId = 1, Foto = "/FotosSistemas/Arcanas_e_Ancestrais.jpg" },
            new Sistema("Som das Seis", "https://www.rpgplanet.com.br/produto/o-som-das-seis", "RPG de faroeste com regras simples e ágeis, inspirado em clássicos do cinema e jogos como Red Dead Redemption.", 2021) { Id = 5, Engine = "Próprio", EditoraId = 1, Foto = "/FotosSistemas/Som_das_Seis.jpg" },
            new Sistema("Nômades", "https://www.catarse.me/nomades", "RPG cooperativo ou solo, sem mestre, focado em jornadas narrativas por mundos misteriosos e interligados.", 2020) { Id = 6, Engine = "Próprio", EditoraId = 1, Foto = "/FotosSistemas/Nomades.jpg" },
            new Sistema("Ludosystem", "https://ludosystem.itch.io/ludosystem-sistema-de-jogos-narrativos", "Sistema de regras genérico e versátil, com foco em narrativas rápidas e divertidas, notável por sua integração com o VTT Roll20.", 2021) { Id = 7, Engine = "Próprio", EditoraId = 1, Foto = "/FotosSistemas/Ludosystem.jpg" },
            new Sistema("O Mundo Secreto", "https://www.catarse.me/OMundoSecretoRPG", "RPG onde crianças transformam seus medos em aventuras, explorando um mundo de fantasia e coragem.", 2024) { Id = 8, Engine = "Próprio", EditoraId = 1, Foto = "/FotosSistemas/O_Mundo_Secreto.jpg" },
            new Sistema("Tormenta20", "https://jamboeditora.com.br/produto/tormenta20-edicao-jogo-do-ano/", "A mais recente edição do maior cenário de fantasia medieval do Brasil, com um sistema de regras robusto e um vasto mundo para explorar.", 2019) { Id = 9, Engine = "Próprio (d20)", EditoraId = 2, Foto = "/FotosSistemas/Tormenta20.jpg" },
            new Sistema("Ordem Paranormal RPG", "https://jamboeditora.com.br/produto/ordem-paranormal-rpg/", "Baseado na websérie de sucesso, este RPG coloca os jogadores como agentes de uma organização que investiga e combate o paranormal.", 2022) { Id = 10, Engine = "Próprio", EditoraId = 2, Foto = "/FotosSistemas/Ordem_Paranormal.jpg" },
            new Sistema("3D&T Alpha", "https://jamboeditora.com.br/produto/3dt-alpha-edicao-revisada/", "Sistema rápido e divertido, ideal para aventuras inspiradas em animes e videogames, com criação de personagens baseada em pontos.", 2015) { Id = 11, Engine = "3D&T", EditoraId = 2, Foto = "/FotosSistemas/3D_T_Alpha.jpg" },
            new Sistema("Altaris RPG", "https://coisinhaverde.com.br/jogos/portfolio-item/altaris-rpg/", "RPG de mesa que pode ser jogado em grupo ou solo, sem necessidade de mestre, em um mundo de fantasia com exploração e aventura.", 2022) { Id = 12, Engine = "Próprio (d6)", EditoraId = 3, Foto = "/FotosSistemas/Altaris_RPG.jpg" },
            new Sistema("Gatunos", "https://coisinhaverde.com.br/jogos/portfolio-item/gatunos/", "Jogo solo ou cooperativo sem mestre, onde os jogadores são gatos ladrões em uma cidade cheia de intrigas e facções rivais.", 2020) { Id = 13, Engine = "PbtA", EditoraId = 3, Foto = "/FotosSistemas/Gatunos.jpg" },
            new Sistema("Ronin", "https://coisinhaverde.com.br/jogos/portfolio-item/ronin/", "Jogo narrativo solo sobre a jornada de um andarilho em busca de redenção no Japão Feudal.", 2019) { Id = 14, Engine = "Próprio", EditoraId = 3, Foto = "/FotosSistemas/Ronin.jpg" },
            new Sistema("Shadowrun: Sexto Mundo", "https://newordereditora.com/loja/rpg/shadowrun-sexto-mundo/shadowrun-sexto-mundo-livro-basico/", "A sexta edição do clássico RPG que mistura cyberpunk e fantasia, onde tecnologia e magia coexistem em um futuro distópico.", 2022) { Id = 15, Engine = "Shadowrun 6e", EditoraId = 4, Foto = "/FotosSistemas/Shadowrun_6e.jpg" },
            new Sistema("Starfinder", "https://newordereditora.com/loja/rpg/starfinder/starfinder-livro-basico/", "RPG de fantasia científica no espaço, onde os jogadores exploram planetas exóticos, naves espaciais e mistérios cósmicos.", 2018) { Id = 16, Engine = "d20 (Pathfinder)", EditoraId = 4, Foto = "/FotosSistemas/Starfinder.jpg" },
            new Sistema("The Strange", "https://newordereditora.com/loja/rpg/the-strange/the-strange-livro-basico/", "Jogo que utiliza o Cypher System, onde os personagens viajam para realidades alternativas baseadas em mitos e ficção.", 2016) { Id = 17, Engine = "Cypher System", EditoraId = 4, Foto = "/FotosSistemas/The_Strange.jpg" },
            new Sistema("Arquivos Paranormais", "https://lampiaogamestudio.wordpress.com/em-destaque/arquivos-paranormais/", "Jogo de investigação sobrenatural onde os jogadores são agentes de uma agência que lida com fenômenos estranhos.", 2018) { Id = 18, Engine = "L'Aventure", EditoraId = 5, Foto = "/FotosSistemas/Arquivos_Paranormais.jpg" },
            new Sistema("Ceifadores", "https://loja.movimentorpg.com.br/produto/ceifadores/", "RPG sobre assassinos profissionais que devem planejar e executar seus alvos, lidando com os conflitos morais de sua profissão.", 2018) { Id = 19, Engine = "L'Aventure", EditoraId = 5, Foto = "/FotosSistemas/Ceifadores.jpg" },
            new Sistema("Lições", "https://lampiaogamestudio.wordpress.com/em-destaque/licoes-historias-entre-mundos/", "Jogo narrativo sobre estudantes que viajam entre o mundo real e uma realidade paralela para resolver conflitos.", 2022) { Id = 20, Engine = "Próprio", EditoraId = 5, Foto = "/FotosSistemas/Licoes.jpg" },
            new Sistema("Aventuras na Era Hiboriana", "https://www.101games.com.br/product-page/aventuras-na-era-hiboriana-rpg", "RPG no mundo de Conan, o Bárbaro, que pode ser jogado solo, em grupo cooperativo ou com um mestre tradicional.", 2021) { Id = 21, Engine = "Solo 10", EditoraId = 6, Foto = "/FotosSistemas/Aventuras_Era_Hiboriana.jpg" },
            new Sistema("A Herança de Cthulhu", "https://www.101games.com.br/product-page/a-heran%C3%A7a-de-cthulhu-pdf", "Jogo de sobrevivência em um mundo pós-apocalíptico destruído pelo despertar dos Grandes Antigos.", 2020) { Id = 22, Engine = "Solo 10", EditoraId = 6, Foto = "/FotosSistemas/Heranca_de_Cthulhu.jpg" },
            new Sistema("Vampiro: Sozinho na Escuridão", "https://www.101games.com.br/product-page/vampiro-sozinho-na-escurid%C3%A3o-pdf", "RPG solo onde o jogador interpreta um vampiro lutando para sobreviver em um mundo hostil.", 2020) { Id = 23, Engine = "Solo 10", EditoraId = 6, Foto = "/FotosSistemas/Vampiro_Sozinho_Escuridao.jpg" },
            new Sistema("Old Dragon 2", "https://burobrasil.com/old-dragon-2/", "A segunda edição do popular retro-clone brasileiro, que busca emular a experiência dos RPGs clássicos com regras modernizadas.", 2022) { Id = 24, Engine = "OSR (d20)", EditoraId = 7, Foto = "/FotosSistemas/Old_Dragon_2.jpg" },
            new Sistema("Space Dragon", "https://burobrasil.com/space-dragon/", "Aventura e exploração espacial no estilo pulp, usando as regras simples de Old Dragon para viagens interplanetárias.", 2020) { Id = 25, Engine = "Old Dragon", EditoraId = 7, Foto = "/FotosSistemas/Space_Dragon.jpg" },
            new Sistema("Kult: Divindade Perdida", "https://www.burobrasil.com/produtos/kult/", "Reboot do aclamado RPG de horror contemporâneo, onde a realidade é uma ilusão que esconde um inferno eterno.", 2020) { Id = 26, Engine = "PbtA", EditoraId = 7, Foto = "/FotosSistemas/Kult_Divindade_Perdida.jpg" },
            new Sistema("Brave Zenith", "https://editoradraco.com/produto/brave-zenith/", "RPG pós-apocalíptico com humor e surrealismo, inspirado na cultura brasileira e em JRPGs clássicos.", 2023) { Id = 27, Engine = "Próprio (2d6)", EditoraId = 8, Foto = "/FotosSistemas/Brave_Zenith.jpg" },
            new Sistema("Apocalypse World", "https://seculargames.com.br/loja/index.php/produto/apocalypse-world/", "O jogo que originou o motor PbtA, focado na sobrevivência e nas relações em um mundo pós-apocalíptico.", 2019) { Id = 28, Engine = "PbtA", EditoraId = 9, Foto = "/FotosSistemas/Apocalypse_World.jpg" },
            new Sistema("Dungeon World", "https://seculargames.com.br/loja/index.php/produto/dungeon-world/", "RPG de fantasia que combina a pegada dos jogos clássicos com regras modernas e narrativas, usando o sistema PbtA.", 2017) { Id = 29, Engine = "PbtA", EditoraId = 9, Foto = "/FotosSistemas/Dungeon_World.jpg" },
            new Sistema("Goddess Save the Queen", "https://seculargames.com.br/loja/index.php/produto/goddess-save-the-queen-pdf/", "Jogo de aventura, ação e mistério ambientado nos anos 20, com uma pegada pulp e investigativa.", 2018) { Id = 30, Engine = "Queen System", EditoraId = 9, Foto = "/FotosSistemas/Goddess_Save_the_Queen.jpg" }
        );

        modelBuilder.Entity<Sistema>()
           .HasMany(s => s.Generos)
           .WithMany(g => g.Sistemas)
           .UsingEntity<Dictionary<string, object>>(
                "GeneroSistema",
                j => j
                   .HasOne<Genero>()
                   .WithMany()
                   .HasForeignKey("GenerosId"),
                j => j
                   .HasOne<Sistema>()
                   .WithMany()
                   .HasForeignKey("SistemasId"),
                j =>
                {
                    j.HasKey("GenerosId", "SistemasId");
                    j.HasData(
                        new { GenerosId = 1, SistemasId = 1 }, new { GenerosId = 2, SistemasId = 1 }, new { GenerosId = 3, SistemasId = 1 },
                        new { GenerosId = 9, SistemasId = 2 }, new { GenerosId = 13, SistemasId = 2 },
                        new { GenerosId = 4, SistemasId = 3 }, new { GenerosId = 14, SistemasId = 3 },
                        new { GenerosId = 3, SistemasId = 4 }, new { GenerosId = 4, SistemasId = 4 }, new { GenerosId = 7, SistemasId = 4 }, new { GenerosId = 2, SistemasId = 4 },
                        new { GenerosId = 8, SistemasId = 5 }, new { GenerosId = 2, SistemasId = 5 },
                        new { GenerosId = 2, SistemasId = 6 }, new { GenerosId = 3, SistemasId = 6 }, new { GenerosId = 11, SistemasId = 6 },
                        new { GenerosId = 2, SistemasId = 7 },
                        new { GenerosId = 2, SistemasId = 8 }, new { GenerosId = 3, SistemasId = 8 },
                        new { GenerosId = 1, SistemasId = 9 }, new { GenerosId = 2, SistemasId = 9 }, new { GenerosId = 3, SistemasId = 9 },
                        new { GenerosId = 4, SistemasId = 10 }, new { GenerosId = 12, SistemasId = 10 }, new { GenerosId = 5, SistemasId = 10 },
                        new { GenerosId = 6, SistemasId = 11 }, new { GenerosId = 2, SistemasId = 11 }, new { GenerosId = 10, SistemasId = 11 },
                        new { GenerosId = 3, SistemasId = 12 }, new { GenerosId = 2, SistemasId = 12 }, new { GenerosId = 11, SistemasId = 12 },
                        new { GenerosId = 2, SistemasId = 13 }, new { GenerosId = 3, SistemasId = 13 }, new { GenerosId = 11, SistemasId = 13 },
                        new { GenerosId = 2, SistemasId = 14 }, new { GenerosId = 11, SistemasId = 14 },
                        new { GenerosId = 9, SistemasId = 15 }, new { GenerosId = 3, SistemasId = 15 }, new { GenerosId = 13, SistemasId = 15 },
                        new { GenerosId = 13, SistemasId = 16 }, new { GenerosId = 2, SistemasId = 16 }, new { GenerosId = 3, SistemasId = 16 },
                        new { GenerosId = 13, SistemasId = 17 }, new { GenerosId = 3, SistemasId = 17 }, new { GenerosId = 2, SistemasId = 17 },
                        new { GenerosId = 12, SistemasId = 18 }, new { GenerosId = 4, SistemasId = 18 }, new { GenerosId = 5, SistemasId = 18 },
                        new { GenerosId = 12, SistemasId = 19 }, new { GenerosId = 2, SistemasId = 19 },
                        new { GenerosId = 3, SistemasId = 20 }, new { GenerosId = 2, SistemasId = 20 },
                        new { GenerosId = 1, SistemasId = 21 }, new { GenerosId = 2, SistemasId = 21 }, new { GenerosId = 14, SistemasId = 21 },
                        new { GenerosId = 4, SistemasId = 22 }, new { GenerosId = 14, SistemasId = 22 }, new { GenerosId = 13, SistemasId = 22 },
                        new { GenerosId = 4, SistemasId = 23 }, new { GenerosId = 5, SistemasId = 23 }, new { GenerosId = 11, SistemasId = 23 },
                        new { GenerosId = 1, SistemasId = 24 }, new { GenerosId = 7, SistemasId = 24 }, new { GenerosId = 2, SistemasId = 24 },
                        new { GenerosId = 13, SistemasId = 25 }, new { GenerosId = 2, SistemasId = 25 },
                        new { GenerosId = 4, SistemasId = 26 }, new { GenerosId = 5, SistemasId = 26 }, new { GenerosId = 12, SistemasId = 26 },
                        new { GenerosId = 3, SistemasId = 27 }, new { GenerosId = 2, SistemasId = 27 }, new { GenerosId = 10, SistemasId = 27 },
                        new { GenerosId = 13, SistemasId = 28 }, new { GenerosId = 14, SistemasId = 28 }, new { GenerosId = 2, SistemasId = 28 },
                        new { GenerosId = 1, SistemasId = 29 }, new { GenerosId = 2, SistemasId = 29 }, new { GenerosId = 7, SistemasId = 29 },
                        new { GenerosId = 2, SistemasId = 30 }, new { GenerosId = 12, SistemasId = 30 }
                    );
                }
            );
    }
}

