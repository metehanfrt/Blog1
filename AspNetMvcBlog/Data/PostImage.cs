using AspNetMvcBlog.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcBlog.Data
{
    public class PostImage
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string ImagePath { get; set; }

        public Post Post { get; set; }
    }
}