using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Logic
{
    public class Inventory
    {
        private readonly Data.InventoryRepository repo = new Data.InventoryRepository();
        public List<Models.Medal> GetMedals()
        {
            return repo.GetAllMedals();
        }
        public List<Models.Badge> GetBadges()
        {
            return repo.GetAllBadges();
        }
        public List<Models.Product> GetAll()
        {
            List<Models.Product> products = new List<Models.Product>();
            products.AddRange(GetMedals());
            products.AddRange(GetBadges());
            return products;
        }



    }
}
