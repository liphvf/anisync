using anisync.Models.Kitsu.AnimeMangaGenericReponse;

namespace anisync.Models.Kitsu.StructuredModels;

public class AnimeEntryDto
{
    public int EntryId { get; set; }

    public EntryAttribute EntryAttribute { get; set; } = new();

    public required IAnimeAttribute AnimeAttribute { get; set; }
}
