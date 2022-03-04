namespace anisync.Models.Kitsu
{
    public class ResponseKitsu<T>
    {
        public List<T> Data { get; set; }
        public Links Links { get; set; }
    }
}