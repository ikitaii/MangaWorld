namespace MangaWorld.Models
{
    public class ReaderViewModel
    {
        public string MangaSlug { get; set; } = string.Empty;

        public string MangaTitle { get; set; } = string.Empty;

        public string OriginalTitle { get; set; } = string.Empty;

        public int MangaId { get; set; }

        public int ChapterId { get; set; }

        public int ChapterNumber { get; set; }

        public string ChapterName { get; set; } = string.Empty;

        public IReadOnlyList<ReaderPageViewModel> Pages { get; set; } = Array.Empty<ReaderPageViewModel>();

        public IReadOnlyList<MangaChapterItemViewModel> Chapters { get; set; } = Array.Empty<MangaChapterItemViewModel>();

        public int? PreviousChapterNumber { get; set; }

        public int? NextChapterNumber { get; set; }

        public int? LastChapterNumber { get; set; }

        public int? CurrentUserPage { get; set; }

        public RichCommentsSectionViewModel CommentsSection { get; set; } = new();

        public IReadOnlyList<ReaderCommentViewModel> Comments { get; set; } = Array.Empty<ReaderCommentViewModel>();
    }

    public class ReaderPageViewModel
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public IReadOnlyList<RichCommentViewModel> Comments { get; set; } = Array.Empty<RichCommentViewModel>();
    }

    public class ReaderCommentViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}
