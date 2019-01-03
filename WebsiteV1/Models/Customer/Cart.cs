using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteV1.Models.Webshop
{
    public class Cart
    {
        public List<Products.Product> Products { get; private set; }

        public Cart()
        {
            
        }

        public bool AddProduct(Products.Product product)
        {
            try
            {
                Products.Add(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddProduct(List<Products.Product> products)
        {
            try
            {
                Products.AddRange(products);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
