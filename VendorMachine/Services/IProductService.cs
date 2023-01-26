using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.Models;

namespace VendorMachine.Services
{
    public interface IProductService
    {
        void SelectProduct(int selectedProduct);
    }

    public class ProductFactory
    {
        public static IProductService GetInstance()
        {
            return new ProductService();
        }
    }

    public class ProductService : IProductService
    {
        public void SelectProduct(int selectedProduct)
        {
            Product product = null;
            switch (selectedProduct)
            {
                case 1:
                    product = Vendor.Products.Where(x => x.ProductName == "Cola").FirstOrDefault();
                    if (Vendor.Amount > product.Price)
                    {
                        Console.WriteLine("COLA Dispensed...");
                    }
                    else
                    {
                        Console.WriteLine("Low Balance for COLA");
                    }
                    break;
                case 2:
                    product = Vendor.Products.Where(x => x.ProductName == "Chips").FirstOrDefault();
                    if (Vendor.Amount > product.Price)
                    {
                        Console.WriteLine("CHIPS Dispensed...");
                    }
                    else
                    {
                        Console.WriteLine("Low Balance for CHIPS");
                    }
                    break;
                case 3:
                    product = Vendor.Products.Where(x => x.ProductName == "Candy").FirstOrDefault();
                    if (Vendor.Amount > product.Price)
                    {
                        Console.WriteLine("CANDY Dispensed...");
                    }
                    else
                    {
                        Console.WriteLine("Low Balance for CANDY");
                    }
                    break;
                default:
                    Console.WriteLine("Please select a valid Product...i.e.(COLA=1, CHIPS=2, CANDY=3)");
                    break;
            }
        }
    }
}
