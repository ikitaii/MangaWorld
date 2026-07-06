using System.ComponentModel.DataAnnotations;

namespace MangaWorld.Models
{
    public class ReportForumCommentInputModel
    {
        [Required]
        public int CommentId { get; set; }

        [Required]
        public int TopicId { get; set; }

        [Required]
        public string Reason { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Details { get; set; }
    }

    public class ReportMangaCommentInputModel
    {
        [Required]
        public int CommentId { get; set; }

        [Required]
        public int MangaId { get; set; }

        [Required]
        public string Reason { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Details { get; set; }
    }

    public class ReportChapterInputModel
    {
        [Required]
        public int ChapterId { get; set; }

        [Required]
        public string Reason { get; set; } = string.Empty;

        [Required]
        [StringLength(2000)]
        public string Details { get; set; } = string.Empty;
    }

    public class ProfileQueryDto
    {
        public string Tab { get; set; } = "titles";

        public int? ListId { get; set; }

        public string? Search { get; set; }

        public string? Sort { get; set; }

        public string View { get; set; } = "list";

        public string ListSort { get; set; } = "title_asc";

        public string Order { get; set; } = "desc";

        public string SettingsSection { get; set; } = "profile";

        public string ReviewFilter { get; set; } = "new";

        public string FriendsSection { get; set; } = "list";

        public string? FriendsSearch { get; set; }

        public int? ConversationId { get; set; }

        public int? TargetUserId { get; set; }

        public string SubmissionSection { get; set; } = "titles";

        public string SubmissionStatus { get; set; } = "moderation";

        public string? SubmissionSearch { get; set; }

        public string? SubmissionCategory { get; set; }

        public string SubmissionSort { get; set; } = "popularity";
    }

    public class ProfileListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Count { get; set; }

        public bool IsAll { get; set; }
    }

    public class ProfileTitleItemViewModel
    {
        public int MangaId { get; set; }

        public int CollectionId { get; set; }

        public string MangaSlug { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string? CoverImage { get; set; }

        public decimal Rating { get; set; }

        public int ChaptersCount { get; set; }

        public int? LastReadChapter { get; set; }

        public int? TotalChaptersRead { get; set; }

        public DateTime AddedAt { get; set; }

        public DateTime MangaUpdatedAt { get; set; }

        public DateTime? LastReadAt { get; set; }

        public int? UserScore { get; set; }
    }
}
