using anisync.Models.Kitsu;
using anisync.Models.Kitsu.StructuredModels;
using AnySync.Brazor.Data.DatabaseModels;

namespace AnySync.Brazor.Mappers;

public static class MangaEntryMapper
{
    public static void MapOver(this MangaEntry entry, MangaEntryDto dto)
    {
        entry.KitsuId = dto.EntryId;
        // entry.AnilistId = ;
        entry.CanonicalTitle = dto.MangaAttribute.canonicalTitle;
        entry.AlternativesTitles = ConvertTitle(dto.MangaAttribute.titles);
        entry.ChapterCount = dto.MangaAttribute.chapterCount;
        entry.slug = dto.MangaAttribute.slug;
        entry.ImageURL = dto.MangaAttribute?.posterImage?.small;
        entry.KitsuLink = $"https://kitsu.io/manga/{dto.MangaAttribute?.slug}";
        // entry.AnilistLink = ;
        entry.Status = ConvertStatus(dto.EntryAttribute.status);
        entry.Score = dto.EntryAttribute.ratingTwenty;
        entry.ChapterProgress = dto.EntryAttribute.progress;
        entry.RereadCount = dto.EntryAttribute.reconsumeCount;
        entry.StartDate = dto.EntryAttribute.startedAt;
        entry.FinishDate = dto.EntryAttribute.finishedAt;
        entry.Notes = dto.EntryAttribute.notes;
        entry.Public = !dto.EntryAttribute.@private;
    }

    public static MangaEntry MapNewMangaEntry(this MangaEntryDto dto)
    {
        var mangaEntry = new MangaEntry
        {
            CanonicalTitle = dto.MangaAttribute.canonicalTitle,
            slug = dto.MangaAttribute.slug
        };
        mangaEntry.MapOver(dto);

        return mangaEntry;
    }

    private static List<string> ConvertTitle(Titles? titles)
    {
        var titlesOnList = new List<string>();

        if (titles == null) return titlesOnList;

        if (!string.IsNullOrWhiteSpace(titles.en))
        {
            titlesOnList.Add(titles.en);
        }

        if (!string.IsNullOrWhiteSpace(titles.ja_jp))
        {
            titlesOnList.Add(titles.ja_jp);
        }

        if (!string.IsNullOrWhiteSpace(titles.en_jp))
        {
            titlesOnList.Add(titles.en_jp);
        }

        return titlesOnList;
    }

    public static MangaStatus ConvertStatus(string status)
    {
        return status.ToLower() switch
        {
            "current" => MangaStatus.Reading,
            "completed" => MangaStatus.Completed,
            "rewatching" => MangaStatus.Rereading,
            "on_hold" => MangaStatus.Paused,
            "dropped" => MangaStatus.Dropped,
            "planned" => MangaStatus.PlanToRead,
            _ => throw new ApplicationException($"status não encontrado: {status}"),
        };
    }
}
