namespace MangaWorld.Models
{
    public class NotificationsQueryDto
    {
        public string Category { get; set; } = "all";

        public string ReadFilter { get; set; } = "all";

        public string Sort { get; set; } = "newest";

        public string? Search { get; set; }

        public int Page { get; set; } = 1;

        public NotificationType? CategoryType { get; set; }
    }

    public class NotificationItemViewModel
    {
        public int Id { get; set; }

        public NotificationType Type { get; set; }

        public bool IsRead { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ActorUsername { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string? ContextText { get; set; }

        public string? CoverImage { get; set; }

        public string? LinkUrl { get; set; }
    }

    public class NotificationsPageViewModel
    {
        public NotificationsQueryDto Query { get; set; } = new();

        public IReadOnlyList<NotificationItemViewModel> Items { get; set; } = Array.Empty<NotificationItemViewModel>();

        public int TotalCount { get; set; }

        public int TotalPages { get; set; }

        public int AllCount { get; set; }

        public int ChaptersCount { get; set; }

        public int RepliesCount { get; set; }

        public int MessagesCount { get; set; }

        public int OtherCount { get; set; }
    }
}
