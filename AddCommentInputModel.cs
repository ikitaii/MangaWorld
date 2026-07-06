using System.ComponentModel.DataAnnotations;

namespace MangaWorld.Models
{
    public class AddCommentInputModel
    {
        [Required]
        public int MangaId { get; set; }

        public int? ChapterId { get; set; }

        public int? PageNumber { get; set; }

        public int? ParentCommentId { get; set; }

        [Required]
        [StringLength(1500, MinimumLength = 2)]
        public string Text { get; set; } = string.Empty;
    }
}
