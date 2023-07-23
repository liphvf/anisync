namespace anisync.Models.Kitsu.AnimeMangaGenericReponse;

public interface IAnimeMangaBaseAttribute
{
    public DateTime createdAt { get; set; }
    public DateTime? updatedAt { get; set; }
    public string slug { get; set; }
    public string? synopsis { get; set; }
    public string? description { get; set; }
    public int? coverImageTopOffset { get; set; }
    public Titles? titles { get; set; }
    public string canonicalTitle { get; set; }
    public List<string> abbreviatedTitles { get; set; }
    public string? averageRating { get; set; }
    public int? userCount { get; set; }
    public int? favoritesCount { get; set; }
    public string? startDate { get; set; }
    public string? endDate { get; set; }
    // public object nextRelease { get; set; }
    public int? popularityRank { get; set; }
    public int? ratingRank { get; set; }
    public string? ageRating { get; set; }
    public string? ageRatingGuide { get; set; }
    public string? subtype { get; set; }
    public string? status { get; set; }
    // public object tba { get; set; }
    public PosterImage? posterImage { get; set; }
    public CoverImage? coverImage { get; set; }
}
