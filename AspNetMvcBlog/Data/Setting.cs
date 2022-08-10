using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcBlog.Data.Models
{
    public class Setting
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string? Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string? Value { get; set; }
    }
}