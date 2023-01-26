using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine.Services
{
    public class VendorMachineService
    {
        /* We can also use DI here using cunstructor instead of direct initialization */
        IVendor _vendor = null;
        IVendor Vendor
        {
            get
            {
                return _vendor = _vendor ?? VendorFactory.GetInstance();
            }
        }

        IProductService _product = null;
        IProductService Product
        {
            get
            {
                return _product = _product ?? ProductFactory.GetInstance();
            }
        }

        /// <summary>
        /// this this just Sample to call automatically...
        /// </summary>

        public void OperateMachine()
        {
            Vendor.AcceptCoins(2, Models.CoinType.Nickels);

            Console.WriteLine("Displaying Balance...");
            Vendor.DisplayBalance();

            Console.WriteLine("Selecting Product...");
            Product.SelectProduct(1);
        }
    }
}
