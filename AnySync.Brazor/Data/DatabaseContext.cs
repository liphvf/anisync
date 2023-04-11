using AnySync.Brazor.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace AnySync.Brazor.Data;

public class DatabaseContext : DbContext
{
    public required DbSet<AnimeEntry> AnimesEntries { get; set; }
    public required DbSet<MangaEntry> MangasEntries { get; set; }
    public required DbSet<User> Users { get; set; }
    public required DbSet<Library> Library { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseNpgsql($"Database=AniSync;Server=127.0.0.1;Port=5432;UserId=postgres;Password=Aspirin@;CommandTimeout=300;Pooling=False;MaxPoolSize=1024;ConnectionIdleLifeTime=600;"
    , o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).UseSnakeCaseNamingConvention();

}
