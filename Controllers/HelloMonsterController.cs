﻿using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMonster.Controllers
{
    public class HelloMonsterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}