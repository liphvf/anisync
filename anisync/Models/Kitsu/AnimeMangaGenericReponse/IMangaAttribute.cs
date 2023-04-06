namespace anisync.Models.Kitsu.AnimeMangaGenericReponse;

public interface IMangaAttribute : IAnimeMangaBaseAttribute
{
    public int? chapterCount { get; set; }
    public int? volumeCount { get; set; }
    public string? serialization { get; set; }
    public string? mangaType { get; set; }
}
