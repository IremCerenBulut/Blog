using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category> Categories =>Set<Category>();
        public DbSet<Post> Posts => Set<Post>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "General"},
                new Category() { Id = 2, Name = "My Business World"},
                new Category() { Id = 3, Name = "My Travels"},
                new Category() { Id = 4, Name = "My Kitchen" }
                );
            modelBuilder.Entity<Post>().HasData(ExamplePosts());
        }
        private Post[] ExamplePosts()
        {
            var posts = new Post[48];

            for (int i = 0; i < posts.Length; i++)
            {
                posts[i] = new Post()
                {
                    Id = i + 1,
                    Title = $"Sample Text {i+1}",
                    Content= @" 
                            <p>Tincidunt integer eu augue augue nunc elit dolor, luctus          placerat scelerisque euismod, iaculis eu lacus nunc mi elit,        vehicula ut laoreet ac, aliquam sit amet justo nunc                 tempor, metus vel.</p>
                            <p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi      odio eget   lorem nulla condimentum tempor mattis ut vitae          feugiat augue cras ut       metus a risus iaculis scelerisque       eu ac ante.</p>",
                    CategoryId=i / 12 + 1,
                };
            }
            return posts;
        }
    }   
}
