using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteV1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult Login()
        {
            return Content("On Succeed");
        }
    }
}