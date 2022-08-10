using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext db;

        public SearchController(AppDbContext db)
        {
            this.db = db;
        }
        
        [HttpPost]
        public IActionResult Index(string q)
        {
            var searchList = db.Posts.Where(x => x.Title == q || x.Content == q).ToList();
            return View(searchList);
        }

    }
}
