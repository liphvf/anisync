namespace AnySync.Brazor.Data.DatabaseModels;

public class AnimeEntry
{
    public int Id { get; set; }

    public int KitsuId { get; set; }

    public int AnilistId { get; set; }

    public required string CanonicalTitle { get; set; }

    public List<string>? AlternativesTitles { get; set; }

    public int EpisodeCount { get; set; }

    public required string slug { get; set; }

    public string? ImageURL { get; set; }
    
    public string? KitsuLink { get; set; }

    public string? AnilistLink { get; set; }

    public AnimeStatus Status { get; set; }

    public int Score { get; set; }

    public int Progress { get; set; }

    public int RewatchCount { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }

    public string? Notes { get; set; }

    public bool Public { get; set; }
}
