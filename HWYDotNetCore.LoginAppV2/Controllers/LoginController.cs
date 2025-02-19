using HWYDotNetCore.LoginAppV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HWYDotNetCore.LoginAppV2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult LoginIndex(LoginModel reqModel)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddSeconds(10);
            Response.Cookies.Append("UserName", reqModel.UserName, option);
            return Redirect("/Login");

        }
    }
}
