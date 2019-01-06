using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteV1.Models.Products
{
    public class Badge : Product
    {
        public Badge(string name, string description, decimal price, int id)
        {
            Name = name;
            Description = description;
            Price = price;
            ID = id;
        }
    }
}
