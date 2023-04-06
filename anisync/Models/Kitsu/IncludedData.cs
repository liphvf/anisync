using anisync.Models.Kitsu.AnimeMangaGenericReponse;

namespace anisync.Models.Kitsu;

public class IncludedData : RelationshipData
{
    public AnimeMangaGenericAttribute attributes { get; set; } = new();
}

