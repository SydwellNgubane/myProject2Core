using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTwoMVC.Controllers
{
    public class NormalController : Controller
    {
        // GET: /<controller>/
        public IActionResult NormalIndex()
        {
            return View();
        }
        /*----------------------------------*/
        public IActionResult NormalLogin()
        {
            return View();
        }
        /*----------------------------------*/
    }
}
