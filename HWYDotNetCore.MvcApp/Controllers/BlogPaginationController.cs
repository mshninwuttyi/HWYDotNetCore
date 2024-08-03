using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MvcApp.Controllers
{
    public class BlogPaginationController : Controller
    {
        public IActionResult BlogIndex()
        {
            //AppDbContext db = new AppDbContext();
            return View("BlogIndex");
        }
    }
}
