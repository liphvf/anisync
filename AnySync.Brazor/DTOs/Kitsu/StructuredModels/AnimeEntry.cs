using anisync.Models.Kitsu.AnimeData;
using anisync.Models.Kitsu.AnimeMangaGenericReponse;

namespace anisync.Models.Kitsu.StructuredModels;

public class AnimeEntry
{
    public int EntryId { get; set; }

    public EntryAttribute EntryAttribute { get; set; } = new();

    public IAnimeAttribute AnimeAttribute { get; set; }
}
