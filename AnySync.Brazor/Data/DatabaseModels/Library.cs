namespace AnySync.Brazor.Data.DatabaseModels;

public class Library
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public required List<AnimeEntry> AnimesEntries { get; set; }

    public required List<MangaEntry> MangaEntries { get; set; }
}
