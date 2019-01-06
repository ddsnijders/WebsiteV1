using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteV1.Controllers
{
    public class ShopPageController : Controller
    {
        Models.ShopPage.ProductViewModel productVM = new Models.ShopPage.ProductViewModel();
        Website.Logic.Inventory logic = new Website.Logic.Inventory();

        public ShopPageController()
        {
            productVM = new Models.ShopPage.ProductViewModel();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Medals()
        {
            productVM.Products.AddRange(logic.GetMedals());
            return View(productVM);
        }
        public IActionResult Badges()
        {
            productVM.Products.AddRange(logic.GetBadges());
            return View();
        }
    }
}