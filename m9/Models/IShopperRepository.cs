using System;
using System.Linq;

namespace m9.Models
{
    public interface IShopperRepository
    {
        IQueryable<Shopper> Shoppers { get; }

        void SaveShopper(Shopper shopper);
    }
}
