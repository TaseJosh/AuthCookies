﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthCookies.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
