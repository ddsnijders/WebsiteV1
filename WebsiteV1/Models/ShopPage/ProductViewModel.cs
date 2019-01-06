using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteV1.Models.ShopPage
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Products = new List<Website.Models.Product>();
        }
        public List<Website.Models.Product> Products { get; private set; }
    }
}
