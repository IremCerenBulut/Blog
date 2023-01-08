namespace Blog.Models
{
    public class HomeViewModel
    {
        public int? CategoryId { get; set; }
        public List<Post> Posts { get; set; } = new();
        public int Page { get; set; }
        public int NumberOfPage { get; set; }
        public bool OldSkirts => NumberOfPage > Page;
        public bool NewComer => Page > 1;
    }
}
