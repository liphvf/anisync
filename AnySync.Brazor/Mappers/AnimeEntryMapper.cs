using anisync.Models.Kitsu;
using anisync.Models.Kitsu.StructuredModels;
using AnySync.Brazor.Data.DatabaseModels;

namespace AnySync.Brazor.Mappers;

public static class AnimeEntryMapper
{
    public static void MapOver(this AnimeEntry entry, AnimeEntryDto dto)
    {
        entry.KitsuId = dto.EntryId;
        // entry.AnilistId = ;
        entry.CanonicalTitle = dto.AnimeAttribute.canonicalTitle;
        entry.AlternativesTitles = ConvertTitle(dto.AnimeAttribute.titles);
        entry.EpisodeCount = dto.AnimeAttribute.episodeCount;
        entry.slug = dto.AnimeAttribute.slug;
        entry.ImageURL = dto.AnimeAttribute?.posterImage?.small;
        entry.KitsuLink = $"https://kitsu.io/anime/{dto.AnimeAttribute.slug}";
        // entry.AnilistLink = ;
        entry.Status = ConvertStatus(dto.EntryAttribute.status); // converter
        entry.Score = ConvertRating(dto.EntryAttribute.rating); // converter
        entry.Progress = dto.EntryAttribute.progress; ;
        entry.RewatchCount = dto.EntryAttribute.reconsumeCount;
        entry.StartDate = dto.EntryAttribute.startedAt;
        entry.FinishDate = dto.EntryAttribute.finishedAt;
        entry.Notes = dto.EntryAttribute.notes;
        entry.Public = !dto.EntryAttribute.@private;
    }

    public static AnimeEntry MapNewAnimeEntry(this AnimeEntryDto dto)
    {
        var animeEntry =  new AnimeEntry
        {
            CanonicalTitle = dto.AnimeAttribute.canonicalTitle,
            slug = dto.AnimeAttribute.slug
        };
        animeEntry.MapOver(dto);

        return animeEntry;
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

    private static AnimeStatus ConvertStatus(string status)
    {
        return status.ToLower() switch
        {
            "current" => AnimeStatus.Watching,
            "completed" => AnimeStatus.Completed,
            "rewatching" => AnimeStatus.Rewatching,
            "on_hold" => AnimeStatus.Paused,
            "dropped" => AnimeStatus.Dropped,
            "planned" => AnimeStatus.PlanToWatch,
            _ => throw new ApplicationException($"status não encontrado: {status}"),
        };
    }

    private static int ConvertRating(string rating)
    {
        return 0;
    }
}
