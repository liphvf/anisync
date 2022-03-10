namespace anisync.Models.Kitsu
{
    public class GetLibraryEntriesReponse
    {
        public int id { get; set; }

        public string type { get; set; } = string.Empty;

        public Attributes attributes { get; set; } = new Attributes();

        public Relationships relationships { get; set; } = new Relationships();
    }
}