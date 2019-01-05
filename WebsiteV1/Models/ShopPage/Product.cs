using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteV1.Models.Products
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }

    }
}
