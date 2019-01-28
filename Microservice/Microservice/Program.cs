using Microservice.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice
{
    class Program
    {
        static void Main(string[] args)
        {
            int pil;
            SupplierController callSupplier = new SupplierController();
            Console.WriteLine("Microservice");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("Your Choice: ");
            pil = Convert.ToInt16(Console.ReadLine());
            switch (pil)
            {
                case 1:
                    callSupplier.ManageSupplier();
                    break;


                default:
                    Console.WriteLine("Option not found");
                    Console.Read();
                    break;
            }
        }
    }
}
