namespace like_disc.Core.Models
{
        public partial class Search
    {
        public Search()
        {
            Albums = new();
        }
        public Album Albums { get; set; }
    }
}
