namespace anisync.Models.Kitsu
{
    public class GetLibraryEntriesReponse
    {
        public int id { get; set; }

        public string type { get; set; }

        public Attributes attributes { get; set; }

        public Relationships relationships { get; set; }
    }
}