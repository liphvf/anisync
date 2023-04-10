namespace anisync.Models.Kitsu
{
    public class Relationships
    {
        public Anime anime { get; set; } = new Anime();
        public Manga manga { get; set; } = new Manga();
    }
}