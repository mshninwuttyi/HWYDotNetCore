﻿using Microsoft.AspNetCore.Mvc;

namespace HWYDotNetCore.LoginAppV2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
