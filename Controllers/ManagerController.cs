using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTwoMVC.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult ManagerLogin()
        {
            return View();
        }
        public IActionResult ManagerIndex()
        {
            return View();
        }
    }
}