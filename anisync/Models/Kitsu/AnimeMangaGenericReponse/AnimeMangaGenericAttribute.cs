namespace anisync.Models.Kitsu.AnimeMangaGenericReponse;

public class AnimeMangaGenericAttribute : IAnimeAttribute, IMangaAttribute
{
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public string slug { get; set; } = string.Empty;
    public string synopsis { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public int coverImageTopOffset { get; set; }
    public Titles titles { get; set; } = new();
    public string canonicalTitle { get; set; } = string.Empty;
    public List<string> abbreviatedTitles { get; set; } = new();
    public string averageRating { get; set; } = string.Empty;
    public int userCount { get; set; }
    public int favoritesCount { get; set; }
    public string startDate { get; set; } = string.Empty;
    public string endDate { get; set; } = string.Empty;
    // public object nextRelease { get; set; }
    public int popularityRank { get; set; }
    public int ratingRank { get; set; }
    public string ageRating { get; set; } = string.Empty;
    public string ageRatingGuide { get; set; } = string.Empty;
    public string subtype { get; set; } = string.Empty;
    public string status { get; set; } = string.Empty;
    // public object tba { get; set; }
    public PosterImage posterImage { get; set; } = new();
    public CoverImage coverImage { get; set; } = new();

    #region anime
    public int episodeCount { get; set; }
    public int episodeLength { get; set; }
    public int totalLength { get; set; }
    public string youtubeVideoId { get; set; } = string.Empty;
    public string showType { get; set; } = string.Empty;
    public bool nsfw { get; set; }

    #endregion anime

    #region manga
    public int chapterCount { get; set; }
    public int volumeCount { get; set; }
    public string serialization { get; set; } = string.Empty;
    public string mangaType { get; set; } = string.Empty;
    #endregion manga
}
