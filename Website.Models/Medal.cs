using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Models
{
    public class Medal : Product
    {
        public Medal(string name, string description, decimal price, int id)
        {
            Name = name;
            Description = description;
            Price = price;
            ID = id;
        }
    }
}
