using Microsoft.AspNetCore.Mvc;

namespace Blog.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public CategoriesViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_db.Categories.ToList());
        }
    }
}
