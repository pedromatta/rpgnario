using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompendioRpgBr.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editoras",
                columns: new[] { "Id", "Foto", "Nome", "SiteOficial", "Tipo" },
                values: new object[,]
                {
                    { 1, "/FotosEditoras/Independente.jpg", "Independente", "#", "Agregador" },
                    { 2, "/FotosEditoras/Jambo.jpg", "Jambô", "https://jamboeditora.com.br", "Editora" },
                    { 3, "/FotosEditoras/Coisinha_Verde.jpg", "Coisinha Verde", "https://coisinhaverde.com.br/jogos/", "Editora" },
                    { 4, "/FotosEditoras/New_Order.jpg", "New Order", "https://newordereditora.com/", "Editora" },
                    { 5, "/FotosEditoras/Lampiao_Game_Studio.jpg", "Lampião Game Studio", "https://lampiaogamestudio.wordpress.com/", "Estúdio Independente" },
                    { 6, "/FotosEditoras/101_Games.jpg", "101 Games", "https://www.101games.com.br/", "Estúdio Independente" },
                    { 7, "/FotosEditoras/Buro.jpg", "Buró", "https://www.burobrasil.com/", "Editora" },
                    { 8, "/FotosEditoras/Editora_Draco.jpg", "Editora Draco", "https://editoradraco.com/", "Editora" },
                    { 9, "/FotosEditoras/Secular_Games.jpg", "Secular Games", "https://www.seculargames.com.br/", "Coletivo de Autores Independentes" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, "Magia, espadas, reinos, monstros, e aventuras em mundos inspirados na Idade Média.", "Fantasia Medieval" },
                    { 2, "Exploração, desafios, perigos, recompensas.", "Aventura" },
                    { 3, "Magia, criaturas místicas, heróis épicos.", "Fantasia" },
                    { 4, "Medo, mistério, ameaças sobrenaturais.", "Terror" },
                    { 5, "Magia oculta no mundo moderno.", "Fantasia Urbana" },
                    { 6, "Estilo visual marcante, ação exagerada, drama.", "Anime" },
                    { 7, "Regras clássicas, letalidade, minimalismo.", "Old School" },
                    { 8, "Faroeste, duelos, foras-da-lei, deserto.", "Velho-Oeste" },
                    { 9, "Futuro sombrio, neon, hackers, corporações.", "Cyberpunk" },
                    { 10, "Humor, situações absurdas, leveza.", "Comédia" },
                    { 11, "Aventuras individuais, narrativa pessoal.", "Solo RPG" },
                    { 12, "Mistérios, pistas, dedução, conspirações.", "Investigativo" },
                    { 13, "Tecnologia avançada, viagens espaciais.", "Ficção Científica" },
                    { 14, "Recursos escassos, perigo constante.", "Sobrevivência" }
                });

            migrationBuilder.InsertData(
                table: "Sistemas",
                columns: new[] { "Id", "AnoLancamento", "Descricao", "EditoraId", "Engine", "Foto", "Link", "Nome" },
                values: new object[,]
                {
                    { 1, 2018, "Terceira edição do primeiro RPG criado por brasileiros. O cenário do Tagmar segue a linha Tolkieniana, ambientada em uma terra de fantásticas raças, poderosas criaturas e incríveis magias, com suas história, folclores e lendas.", 1, "Próprio", "/FotosSistemas/Tagmar_3.jpg", "https://www.tagmar.com.br/", "Tagmar 3" },
                    { 2, 2024, "RPG cyberpunk minimalista e premiado, focado em sessões únicas de assaltos de alta tecnologia em um futuro distópico.", 1, "Forged in the Dark", "/FotosSistemas/CBR_PNK.jpg", "https://cabinetofcuriosities.games/", "CBR+PNK" },
                    { 3, 2024, "RPG de horror que emula filmes slasher dos anos 80, onde jogadores interpretam arquétipos clássicos tentando sobreviver a um assassino implacável.", 1, "Próprio (d6)", "/FotosSistemas/Brutal.jpg", "https://www.catarse.me/brutal", "Brutal" },
                    { 4, 2020, "Dungeon crawler de fantasia sombria e horror, com foco em exploração de masmorras, gerenciamento de sanidade e recursos.", 1, "Híbrido (5e + OSR)", "/FotosSistemas/Arcanas_e_Ancestrais.jpg", "https://clubedeautores.com.br/livro/arcanas-ancestrais", "Arcanas & Ancestrais" },
                    { 5, 2021, "RPG de faroeste com regras simples e ágeis, inspirado em clássicos do cinema e jogos como Red Dead Redemption.", 1, "Próprio", "/FotosSistemas/Som_das_Seis.jpg", "https://www.rpgplanet.com.br/produto/o-som-das-seis", "Som das Seis" },
                    { 6, 2020, "RPG cooperativo ou solo, sem mestre, focado em jornadas narrativas por mundos misteriosos e interligados.", 1, "Próprio", "/FotosSistemas/Nomades.jpg", "https://www.catarse.me/nomades", "Nômades" },
                    { 7, 2021, "Sistema de regras genérico e versátil, com foco em narrativas rápidas e divertidas, notável por sua integração com o VTT Roll20.", 1, "Próprio", "/FotosSistemas/Ludosystem.jpg", "https://ludosystem.itch.io/ludosystem-sistema-de-jogos-narrativos", "Ludosystem" },
                    { 8, 2024, "RPG onde crianças transformam seus medos em aventuras, explorando um mundo de fantasia e coragem.", 1, "Próprio", "/FotosSistemas/O_Mundo_Secreto.jpg", "https://www.catarse.me/OMundoSecretoRPG", "O Mundo Secreto" },
                    { 9, 2019, "A mais recente edição do maior cenário de fantasia medieval do Brasil, com um sistema de regras robusto e um vasto mundo para explorar.", 2, "Próprio (d20)", "/FotosSistemas/Tormenta20.jpg", "https://jamboeditora.com.br/produto/tormenta20-edicao-jogo-do-ano/", "Tormenta20" },
                    { 10, 2022, "Baseado na websérie de sucesso, este RPG coloca os jogadores como agentes de uma organização que investiga e combate o paranormal.", 2, "Próprio", "/FotosSistemas/Ordem_Paranormal.jpg", "https://jamboeditora.com.br/produto/ordem-paranormal-rpg/", "Ordem Paranormal RPG" },
                    { 11, 2015, "Sistema rápido e divertido, ideal para aventuras inspiradas em animes e videogames, com criação de personagens baseada em pontos.", 2, "3D&T", "/FotosSistemas/3D_T_Alpha.jpg", "https://jamboeditora.com.br/produto/3dt-alpha-edicao-revisada/", "3D&T Alpha" },
                    { 12, 2022, "RPG de mesa que pode ser jogado em grupo ou solo, sem necessidade de mestre, em um mundo de fantasia com exploração e aventura.", 3, "Próprio (d6)", "/FotosSistemas/Altaris_RPG.jpg", "https://coisinhaverde.com.br/jogos/portfolio-item/altaris-rpg/", "Altaris RPG" },
                    { 13, 2020, "Jogo solo ou cooperativo sem mestre, onde os jogadores são gatos ladrões em uma cidade cheia de intrigas e facções rivais.", 3, "PbtA", "/FotosSistemas/Gatunos.jpg", "https://coisinhaverde.com.br/jogos/portfolio-item/gatunos/", "Gatunos" },
                    { 14, 2019, "Jogo narrativo solo sobre a jornada de um andarilho em busca de redenção no Japão Feudal.", 3, "Próprio", "/FotosSistemas/Ronin.jpg", "https://coisinhaverde.com.br/jogos/portfolio-item/ronin/", "Ronin" },
                    { 15, 2022, "A sexta edição do clássico RPG que mistura cyberpunk e fantasia, onde tecnologia e magia coexistem em um futuro distópico.", 4, "Shadowrun 6e", "/FotosSistemas/Shadowrun_6e.jpg", "https://newordereditora.com/loja/rpg/shadowrun-sexto-mundo/shadowrun-sexto-mundo-livro-basico/", "Shadowrun: Sexto Mundo" },
                    { 16, 2018, "RPG de fantasia científica no espaço, onde os jogadores exploram planetas exóticos, naves espaciais e mistérios cósmicos.", 4, "d20 (Pathfinder)", "/FotosSistemas/Starfinder.jpg", "https://newordereditora.com/loja/rpg/starfinder/starfinder-livro-basico/", "Starfinder" },
                    { 17, 2016, "Jogo que utiliza o Cypher System, onde os personagens viajam para realidades alternativas baseadas em mitos e ficção.", 4, "Cypher System", "/FotosSistemas/The_Strange.jpg", "https://newordereditora.com/loja/rpg/the-strange/the-strange-livro-basico/", "The Strange" },
                    { 18, 2018, "Jogo de investigação sobrenatural onde os jogadores são agentes de uma agência que lida com fenômenos estranhos.", 5, "L'Aventure", "/FotosSistemas/Arquivos_Paranormais.jpg", "https://lampiaogamestudio.wordpress.com/em-destaque/arquivos-paranormais/", "Arquivos Paranormais" },
                    { 19, 2018, "RPG sobre assassinos profissionais que devem planejar e executar seus alvos, lidando com os conflitos morais de sua profissão.", 5, "L'Aventure", "/FotosSistemas/Ceifadores.jpg", "https://loja.movimentorpg.com.br/produto/ceifadores/", "Ceifadores" },
                    { 20, 2022, "Jogo narrativo sobre estudantes que viajam entre o mundo real e uma realidade paralela para resolver conflitos.", 5, "Próprio", "/FotosSistemas/Licoes.jpg", "https://lampiaogamestudio.wordpress.com/em-destaque/licoes-historias-entre-mundos/", "Lições" },
                    { 21, 2021, "RPG no mundo de Conan, o Bárbaro, que pode ser jogado solo, em grupo cooperativo ou com um mestre tradicional.", 6, "Solo 10", "/FotosSistemas/Aventuras_Era_Hiboriana.jpg", "https://www.101games.com.br/product-page/aventuras-na-era-hiboriana-rpg", "Aventuras na Era Hiboriana" },
                    { 22, 2020, "Jogo de sobrevivência em um mundo pós-apocalíptico destruído pelo despertar dos Grandes Antigos.", 6, "Solo 10", "/FotosSistemas/Heranca_de_Cthulhu.jpg", "https://www.101games.com.br/product-page/a-heran%C3%A7a-de-cthulhu-pdf", "A Herança de Cthulhu" },
                    { 23, 2020, "RPG solo onde o jogador interpreta um vampiro lutando para sobreviver em um mundo hostil.", 6, "Solo 10", "/FotosSistemas/Vampiro_Sozinho_Escuridao.jpg", "https://www.101games.com.br/product-page/vampiro-sozinho-na-escurid%C3%A3o-pdf", "Vampiro: Sozinho na Escuridão" },
                    { 24, 2022, "A segunda edição do popular retro-clone brasileiro, que busca emular a experiência dos RPGs clássicos com regras modernizadas.", 7, "OSR (d20)", "/FotosSistemas/Old_Dragon_2.jpg", "https://burobrasil.com/old-dragon-2/", "Old Dragon 2" },
                    { 25, 2020, "Aventura e exploração espacial no estilo pulp, usando as regras simples de Old Dragon para viagens interplanetárias.", 7, "Old Dragon", "/FotosSistemas/Space_Dragon.jpg", "https://burobrasil.com/space-dragon/", "Space Dragon" },
                    { 26, 2020, "Reboot do aclamado RPG de horror contemporâneo, onde a realidade é uma ilusão que esconde um inferno eterno.", 7, "PbtA", "/FotosSistemas/Kult_Divindade_Perdida.jpg", "https://www.burobrasil.com/produtos/kult/", "Kult: Divindade Perdida" },
                    { 27, 2023, "RPG pós-apocalíptico com humor e surrealismo, inspirado na cultura brasileira e em JRPGs clássicos.", 8, "Próprio (2d6)", "/FotosSistemas/Brave_Zenith.jpg", "https://editoradraco.com/produto/brave-zenith/", "Brave Zenith" },
                    { 28, 2019, "O jogo que originou o motor PbtA, focado na sobrevivência e nas relações em um mundo pós-apocalíptico.", 9, "PbtA", "/FotosSistemas/Apocalypse_World.jpg", "https://seculargames.com.br/loja/index.php/produto/apocalypse-world/", "Apocalypse World" },
                    { 29, 2017, "RPG de fantasia que combina a pegada dos jogos clássicos com regras modernas e narrativas, usando o sistema PbtA.", 9, "PbtA", "/FotosSistemas/Dungeon_World.jpg", "https://seculargames.com.br/loja/index.php/produto/dungeon-world/", "Dungeon World" },
                    { 30, 2018, "Jogo de aventura, ação e mistério ambientado nos anos 20, com uma pegada pulp e investigativa.", 9, "Queen System", "/FotosSistemas/Goddess_Save_the_Queen.jpg", "https://seculargames.com.br/loja/index.php/produto/goddess-save-the-queen-pdf/", "Goddess Save the Queen" }
                });

            migrationBuilder.InsertData(
                table: "GeneroSistema",
                columns: new[] { "GenerosId", "SistemasId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 9 },
                    { 1, 21 },
                    { 1, 24 },
                    { 1, 29 },
                    { 2, 1 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 6 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 20 },
                    { 3, 27 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 10 },
                    { 4, 18 },
                    { 4, 22 },
                    { 4, 23 },
                    { 4, 26 },
                    { 5, 10 },
                    { 5, 18 },
                    { 5, 23 },
                    { 5, 26 },
                    { 6, 11 },
                    { 7, 4 },
                    { 7, 24 },
                    { 7, 29 },
                    { 8, 5 },
                    { 9, 2 },
                    { 9, 15 },
                    { 10, 11 },
                    { 10, 27 },
                    { 11, 6 },
                    { 11, 12 },
                    { 11, 13 },
                    { 11, 14 },
                    { 11, 23 },
                    { 12, 10 },
                    { 12, 18 },
                    { 12, 19 },
                    { 12, 26 },
                    { 12, 30 },
                    { 13, 2 },
                    { 13, 15 },
                    { 13, 16 },
                    { 13, 17 },
                    { 13, 22 },
                    { 13, 25 },
                    { 13, 28 },
                    { 14, 3 },
                    { 14, 21 },
                    { 14, 22 },
                    { 14, 28 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 2, 30 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 10, 27 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 12, 26 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 17 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 22 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 25 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 13, 28 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 14, 21 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 14, 22 });

            migrationBuilder.DeleteData(
                table: "GeneroSistema",
                keyColumns: new[] { "GenerosId", "SistemasId" },
                keyValues: new object[] { 14, 28 });

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sistemas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Editoras",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
