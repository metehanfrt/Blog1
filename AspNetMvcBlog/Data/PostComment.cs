using System.ComponentModel.DataAnnotations;

namespace AspNetMvcBlog.Data
{
    public class PostComment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public string? Comment { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = new DateTime();

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}