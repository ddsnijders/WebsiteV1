using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteV1.Controllers
{
    public class ShopPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Medals()
        {
            return View();
        }
        public IActionResult Badges()
        {
            return View();
        }
    }
}