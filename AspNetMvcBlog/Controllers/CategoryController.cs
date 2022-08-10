using AspNetMvcBlog.Data;
using Microsoft.AspNetCore.Mvc;


namespace AspNetMvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int cid)
        {
            return View();
        }
      

    }
}
