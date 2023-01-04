using System.ComponentModel.DataAnnotations;

namespace Blog.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        //navigation property
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
