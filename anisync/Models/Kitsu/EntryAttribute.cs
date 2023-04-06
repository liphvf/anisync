namespace anisync.Models.Kitsu
{
    public class EntryAttribute
    {
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string status { get; set; } = string.Empty;
        public int progress { get; set; }
        public int volumesOwned { get; set; }
        public bool reconsuming { get; set; }
        public int reconsumeCount { get; set; }
        public string? notes { get; set; }
        public bool @private { get; set; }
        public string reactionSkipped { get; set; } = string.Empty;
        public DateTime? progressedAt { get; set; }
        public DateTime? startedAt { get; set; }
        public DateTime? finishedAt { get; set; }
        public string rating { get; set; } = string.Empty;
        public int? ratingTwenty { get; set; }
    }
}