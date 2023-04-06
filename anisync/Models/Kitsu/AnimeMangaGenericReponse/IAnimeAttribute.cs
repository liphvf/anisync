namespace anisync.Models.Kitsu.AnimeMangaGenericReponse;

public interface IAnimeAttribute : IAnimeMangaBaseAttribute
{
    public int episodeCount { get; set; }
    public int episodeLength { get; set; }
    public int totalLength { get; set; }
    public string youtubeVideoId { get; set; }
    public string showType { get; set; }
    public bool nsfw { get; set; }
}
