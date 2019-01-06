using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Data
{
    class InventoryTestSQLContext : IInventoryContext
    {
        public List<Models.Badge> GetAllBadges()
        {
            List<Models.Badge> badges = new List<Models.Badge>();
            badges.Add(new Models.Badge("Test Badge", "This Badge is used for testing", 1, 1));
            badges.Add(new Models.Badge("Test Badge 2", "This Badge is also used for testing", 2, 3));
            return badges;
        }

        public List<Models.Medal> GetAllMedals()
        {
            List<Models.Medal> medals = new List<Models.Medal>();
            medals.Add(new Models.Medal("Test Medal", "This Medal is used for this test", 1, 7));
            medals.Add(new Models.Medal("Test Medal 2", "Testing medal", 6, 4));
            medals.Add(new Models.Medal("Ye", "Ye", 3, 5));
            return medals;
        }
    }
}
