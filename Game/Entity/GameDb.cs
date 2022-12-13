global using Microsoft.EntityFrameworkCore;

namespace Game.Entity;

internal class GameDb : DbContext
{
    public GameDb()
    {

    }

    public GameDb(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Building> Buildings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\User\Desktop\Programy\Game\DB\GameDB.db");
    }
}
