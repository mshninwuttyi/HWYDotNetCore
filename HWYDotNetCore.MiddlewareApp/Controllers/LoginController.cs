using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MiddlewareApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel requestModel)
        {
            return View();
        }
    }

    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
