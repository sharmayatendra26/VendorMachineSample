using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.Services;

namespace VendorMachine
{
    class Program
    {           
        static void Main(string[] args)
        {
            Console.WriteLine("Vendor Machine STARTED...");
            VendorMachineService machineService = new VendorMachineService();

            Console.WriteLine("\nPlease Insert Coins..");
            machineService.OperateMachine();

            Console.ReadLine();
        }
    }
}
