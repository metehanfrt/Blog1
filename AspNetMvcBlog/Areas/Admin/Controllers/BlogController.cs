using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
