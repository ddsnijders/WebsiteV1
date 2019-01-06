using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Data
{
    interface IInventoryContext
    {
        List<Models.Badge> GetAllBadges();

        List<Models.Medal> GetAllMedals();
    }
}
