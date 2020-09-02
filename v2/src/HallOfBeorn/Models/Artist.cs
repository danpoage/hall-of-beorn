namespace HallOfBeorn.Models
{
    public class Artist
        : INamed
    {
        public Artist(string name, string url)
        {
            Name = new Content(name);
            Url = url;
        }

        public Content Name { get; }
        public string Url { get; }
    }
}
