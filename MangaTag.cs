namespace MangaWorld.Models
{
    public class MangaTag
    {
        public int MangaId { get; set; }

        public int TagId { get; set; }

        public Manga Manga { get; set; } = null!;

        public Tag Tag { get; set; } = null!;
    }
}
