using Microsoft.EntityFrameworkCore;
using CompendioRpgBr.Modelos;

namespace CompendioRpgBr.Banco;
public class CompendioRpgBrContext : DbContext
{
    public required DbSet<Editora> Editoras { get; set; }
    public required DbSet<Sistema> Sistemas { get; set; }
    public required DbSet<Genero> Generos { get; set; }

    private string connectionString = "Server=localhost;port=3306;database=compendio_rpg_br;User=api_user;Password=insira-senha-forte;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sistema>()
            .HasMany(s => s.Generos)
            .WithMany(g => g.Sistemas);
    }
}

