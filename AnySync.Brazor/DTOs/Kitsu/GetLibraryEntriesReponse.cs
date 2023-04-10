namespace anisync.Models.Kitsu
{
    public class GetLibraryEntriesReponse
    {
        public int id { get; set; }

        public string type { get; set; } = string.Empty;

        public EntryAttribute attributes { get; set; } = new EntryAttribute();

        public Relationships relationships { get; set; } = new Relationships();
    }
}