namespace MangaWorld.Models
{
    public class ProfileViewModel
    {
        public string Username { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? Avatar { get; set; }

        public string? Bio { get; set; }

        public string? Gender { get; set; }

        public string Theme { get; set; } = "dark";

        public string AccentColor { get; set; } = ThemeDefaults.AccentColor;

        public bool EmailConfirmed { get; set; }

        public bool IsUsernameTaken { get; set; }

        public bool PasswordChangeSuccess { get; set; }

        public string? PasswordErrorField { get; set; }

        public string? PasswordErrorMessage { get; set; }

        public ProfileQueryDto Query { get; set; } = new();

        public IReadOnlyList<ProfileListViewModel> Lists { get; set; } = Array.Empty<ProfileListViewModel>();

        public int? SelectedListId { get; set; }

        public string SelectedListName { get; set; } = "Все";

        public IReadOnlyList<ProfileTitleItemViewModel> TitleItems { get; set; } = Array.Empty<ProfileTitleItemViewModel>();

        public IReadOnlyList<RichCommentViewModel> UserComments { get; set; } = Array.Empty<RichCommentViewModel>();

        public IReadOnlyList<MangaCommentItemViewModel> UserReviews { get; set; } = Array.Empty<MangaCommentItemViewModel>();

        public IReadOnlyList<FriendItemViewModel> Friends { get; set; } = Array.Empty<FriendItemViewModel>();

        public IReadOnlyList<FriendItemViewModel> FriendRequests { get; set; } = Array.Empty<FriendItemViewModel>();

        public IReadOnlyList<FriendItemViewModel> SentFriendRequests { get; set; } = Array.Empty<FriendItemViewModel>();

        public IReadOnlyList<FriendItemViewModel> BlockedUsers { get; set; } = Array.Empty<FriendItemViewModel>();

        public IReadOnlyList<FriendItemViewModel> FriendSearchResults { get; set; } = Array.Empty<FriendItemViewModel>();

        public IReadOnlyList<ConversationItemViewModel> Conversations { get; set; } = Array.Empty<ConversationItemViewModel>();

        public IReadOnlyList<PrivateMessageViewModel> Messages { get; set; } = Array.Empty<PrivateMessageViewModel>();

        public int? ActiveConversationId { get; set; }

        public string? ActiveConversationUsername { get; set; }

        public string? PendingEmail { get; set; }

        public SubmissionsPageViewModel? Submissions { get; set; }
    }

    public class ProfileMangaItemViewModel
    {
        public int MangaId { get; set; }

        public string MangaSlug { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string? CoverImage { get; set; }

        public decimal Rating { get; set; }

        public int ChaptersCount { get; set; }
    }

    public class ReadingHistoryItemViewModel
    {
        public string MangaSlug { get; set; } = string.Empty;

        public string MangaTitle { get; set; } = string.Empty;

        public int ChapterNumber { get; set; }

        public int? PageNumber { get; set; }

        public DateTime LastReadAt { get; set; }
    }
}
