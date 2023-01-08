using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? categoryId, int page=1)
        {
            IQueryable<Post> posts=_db.Posts;
            if (categoryId != null)
            {
                posts = posts.Where(x => x.CategoryId == categoryId);
                ViewBag.Title = _db.Categories.Find(categoryId)?.Name;
            }

            int numberOfPage=(int)Math.Ceiling((double)posts.Count()/Constants.POST_PER_PAGE);

            posts = posts
                .Skip((page - 1) * Constants.POST_PER_PAGE)
                .Take(Constants.POST_PER_PAGE);

            var vm = new HomeViewModel()
            {
                Posts = posts.ToList(),
                Page = page,
                NumberOfPage = numberOfPage
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}