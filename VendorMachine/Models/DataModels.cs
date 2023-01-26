using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine.Models
{
    public class Coin
    {
        public const double COIN_NICKEL = .20;
        public const double COIN_DIM = .10;
        public const double COIN_QURTER = .40;
        public const double COIN_PENNIE = .100;
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    public enum CoinType
    {
        Nickels,
        Dimes,
        Quarters,
        Pennies
    }
}
