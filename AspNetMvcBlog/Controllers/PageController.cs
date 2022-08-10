using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
