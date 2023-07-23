using anisync.Models.Kitsu.AnimeMangaGenericReponse;
using anisync.Models.Kitsu.MangaData;

namespace anisync.Models.Kitsu.StructuredModels;

public class MangaEntryDto
{
    public int EntryId { get; set; }

    public EntryAttribute EntryAttribute { get; set; } = new();

    public IMangaAttribute MangaAttribute { get; set; }
}
