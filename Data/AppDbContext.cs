using RickNMortyDotnetApi.Models.Characters;
using RickNMortyDotnetApi.Models.Episodes;

namespace RickNMortyDotnetApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Episode> Episode { get; set; }
    public DbSet<Character> Characters { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

}