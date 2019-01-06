using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Models
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
        public int ID { get; protected set; }
    }
}
