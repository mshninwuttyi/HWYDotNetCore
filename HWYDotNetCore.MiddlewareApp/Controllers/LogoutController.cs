﻿using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.MiddlewareApp.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();

            return Redirect("/");
        }
    }
}
