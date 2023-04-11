namespace AnySync.Brazor.Data.DatabaseModels;

public class MangaEntry
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

    public MangaStatus Status { get; set; }

    public int Score { get; set; }

    public int ChapterProgress { get; set; }

    public int VolumeProgress { get; set; }

    public int RereadCount { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset FinishDate { get; set; }

    public string? Notes { get; set; }

    public bool Public { get; set; }
}
