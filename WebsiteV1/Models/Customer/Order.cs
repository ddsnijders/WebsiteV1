using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteV1.Models.Customer
{
    public class Order
    {
        public List<Products.Product> Products { get; private set; }
        public int ID { get; private set; }

        public Order()
        {

        }


    }
}
