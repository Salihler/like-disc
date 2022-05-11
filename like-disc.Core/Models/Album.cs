namespace like_disc.Core.Models
{
    public class Album
    {
        public string AlbumType { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Copyright> Copyrights { get; set; }
        public ExternalIds ExternalIds { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public List<object> Genres { get; set; }
        public Uri Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public long Popularity { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string ReleaseDatePrecision { get; set; }
        public long TotalTracks { get; set; }
        public Tracks Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public partial class Artist
    {
        public ExternalUrls ExternalUrls { get; set; }
        public Uri Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public ArtistType Type { get; set; }
        public string Uri { get; set; }
    }

    public partial class ExternalUrls
    {
        public Uri Spotify { get; set; }
    }

    public partial class Copyright
    {
        public string Text { get; set; }
        public string Type { get; set; }
    }

    public partial class ExternalIds
    {
        public string Upc { get; set; }
    }

    public partial class Image
    {
        public long Height { get; set; }
        public Uri Url { get; set; }
        public long Width { get; set; }
    }

    public partial class Tracks
    {
        public Uri Href { get; set; }
        public List<Item> Items { get; set; }
        public long Limit { get; set; }
        public object Next { get; set; }
        public long Offset { get; set; }
        public object Previous { get; set; }
        public long Total { get; set; }
    }

    public partial class Item
    {
        public List<Artist> Artists { get; set; }
        public long DiscNumber { get; set; }
        public long DurationMs { get; set; }
        public bool Explicit { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public Uri Href { get; set; }
        public string Id { get; set; }
        public bool IsLocal { get; set; }
        public bool IsPlayable { get; set; }
        public string Name { get; set; }
        public Uri PreviewUrl { get; set; }
        public long TrackNumber { get; set; }
        public ItemType Type { get; set; }
        public string Uri { get; set; }
    }

    public enum ArtistType { Artist };

    public enum ItemType { Track };
}
