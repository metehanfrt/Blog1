using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcBlog.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Title { get; set; }

        [Column(TypeName = "ntext")]
        public string? Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = new DateTime();

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}