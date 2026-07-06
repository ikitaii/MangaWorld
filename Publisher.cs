namespace MangaWorld.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? AlternativeNames { get; set; }

        public string? CoverImage { get; set; }

        public string Description { get; set; } = string.Empty;

        public int CreatedByUserId { get; set; }

        public ModerationStatus ModerationStatus { get; set; } = ModerationStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ApplicationUser CreatedBy { get; set; } = null!;
    }
}
