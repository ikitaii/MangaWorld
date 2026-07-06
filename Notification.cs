namespace MangaWorld.Models
{
    public enum NotificationType
    {
        Chapter = 0,
        Reply = 1,
        Message = 2,
        Other = 3
    }

    public class Notification
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public NotificationType Type { get; set; }

        public bool IsRead { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? ActorUsername { get; set; }

        public string Message { get; set; } = string.Empty;

        public string? ContextText { get; set; }

        public string? CoverImage { get; set; }

        public string? LinkUrl { get; set; }

        public ApplicationUser User { get; set; } = null!;
    }
}
