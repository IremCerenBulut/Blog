using System.ComponentModel.DataAnnotations;

namespace Blog.Data
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime DateOfUpdate { get; set; } = DateTime.Now;

        [MaxLength(255)]
        public string? Image { get; set; }
        public int CategoryId { get; set; }

        //navigation property
        public List<Category> Categories { get; set; } = null!;

    }
}
