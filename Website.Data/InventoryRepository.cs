using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Data
{
    public class InventoryRepository
    {
        private readonly IInventoryContext context;

        public InventoryRepository()
        {
            context = new InventoryTestSQLContext();
        }

        public List<Models.Badge> GetAllBadges()
        {
            return context.GetAllBadges();
        }

        public List<Models.Medal> GetAllMedals()
        {
            return context.GetAllMedals();
        }
    }
}
