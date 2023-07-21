using AnySync.Brazor.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace AnySync.Brazor.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public required DbSet<AnimeEntry> AnimesEntries { get; set; }
    public required DbSet<MangaEntry> MangasEntries { get; set; }
    public required DbSet<User> Users { get; set; }
    public required DbSet<Library> Library { get; set; }
}
