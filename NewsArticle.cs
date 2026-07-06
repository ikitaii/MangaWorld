namespace MangaWorld.Models
{
    public class NewsArticle
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Slug { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;

        public string? CoverImage { get; set; }

        public bool IsPublished { get; set; }

        public int CreatedByUserId { get; set; }

        public ApplicationUser CreatedBy { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? PublishedAt { get; set; }
    }
}
