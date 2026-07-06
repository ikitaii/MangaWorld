namespace MangaWorld.Models
{
    public class ReadingProgress
    {
        public int UserId { get; set; }

        public int MangaId { get; set; }

        public int ChapterId { get; set; }

        public int? LastPageNumber { get; set; }

        public DateTime LastReadAt { get; set; } = DateTime.UtcNow;

        public ApplicationUser User { get; set; } = null!;

        public Manga Manga { get; set; } = null!;

        public Chapter Chapter { get; set; } = null!;
    }
}
