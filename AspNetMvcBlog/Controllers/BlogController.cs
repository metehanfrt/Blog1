using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }

    }
}
