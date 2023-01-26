using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.Models;

namespace VendorMachine.Services
{
    public interface IVendor
    {
        void AcceptCoins(int numberOfCoins, CoinType coin);
        void DisplayBalance();
    }

    public class VendorFactory
    {
        public static IVendor GetInstance()
        {
            return new Vendor();
        }
    }

    public class Vendor : IVendor
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product { Price=1 , ProductName="Cola"},
            new Product { Price=0.5 , ProductName="Chips"},
            new Product { Price=0.65 , ProductName="Candy"}
        };

        public List<CoinType> ValidCoins = new List<CoinType>()
        {
            CoinType.Nickels, CoinType.Dimes,CoinType.Quarters
        };

        public static double Amount = 0;

        public bool ValidateCoin(CoinType coin)
        {
            if (ValidCoins.Contains(coin))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Coin...");
                return false;
            }
        }

        public void AcceptCoins(int noOfCoins, CoinType coin)
        {
            if (ValidateCoin(coin))
            {
                switch (coin)
                {
                    case CoinType.Nickels: Amount = Coin.COIN_NICKEL * noOfCoins;
                        break;
                    case CoinType.Dimes: Amount = Coin.COIN_DIM * noOfCoins;
                        break;
                    case CoinType.Quarters: Amount = Coin.COIN_QURTER * noOfCoins;
                        break;
                    default:
                        break;
                }
            }
        }

        public void DisplayBalance()
        {
            if (Amount > 0)
            {
                bool hasSufficientBalance = false;
                foreach (var item in Products)
                {
                    if (item.Price <= Amount)
                    {
                        hasSufficientBalance = true;
                    }
                }
                if (hasSufficientBalance)
                {
                    Console.WriteLine("Available Balance= ", Amount);
                }
                else
                {
                    Console.WriteLine("INSERT COIN");
                }
            }
            else
            {
                Console.WriteLine("INSERT COIN");
            }
        }
    }
}
