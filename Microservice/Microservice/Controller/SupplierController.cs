using Microservice.BussinessLogic.Service;
using Microservice.BussinessLogic.Service.Master;
using Microservice.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Controller
{
    
    public class SupplierController 
    {
        iSupplierService _supplierService = new SupplierService();
        SupplierParam supplierParam = new SupplierParam();
        public void ManageSupplier()
        {
            int pil;
            
            Console.WriteLine("Manage Supplier");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Find");
            Console.WriteLine("5. Display All");
            pil = Convert.ToInt16(Console.ReadLine());
            switch (pil)
            {
                case 1:
                    Console.WriteLine("Masukkan Nama Supplier: ");
                    supplierParam.Name = Convert.ToString(Console.ReadLine());
                    _supplierService.Insert(supplierParam);
                    break;

                case 2:
                    Console.WriteLine("Masukkan id Supplier yang ingin diupdate: ");
                    if (string.IsNullOrWhiteSpace(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("input is null or whitespace");
                        Console.Read();
                    }
                    else
                    {
                        supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Masukkan Nama Supplier: ");
                        supplierParam.Name = Convert.ToString(Console.ReadLine());
                        _supplierService.Update(supplierParam.Id, supplierParam);
                    }
                    break;

                case 3:
                    Console.WriteLine("Masukkan id Supplier yang ingin dihapus: ");
                    
                    if (string.IsNullOrWhiteSpace(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("input is null or whitespace");
                        Console.Read();
                    }
                    else
                    {
                        supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                        _supplierService.Delete(supplierParam.Id);
                    }
                    break;

                case 4:
                    Console.WriteLine("Masukkan id Supplier yang ingin dicari: ");
                    if (string.IsNullOrWhiteSpace(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("input is null or whitespace");
                        Console.Read();
                    }
                    else
                    {
                        supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                        var getResult = _supplierService.Get(supplierParam.Id);
                        Console.WriteLine("" + getResult.Nama);
                        Console.Read();
                    }
                    break;

                case 5:
                    foreach (var display in _supplierService.Get()){
                        Console.WriteLine("=============================");
                        Console.WriteLine("Name          : "+display.Nama);
                    }
                    Console.Read();
                    break;

                default:
                    Console.WriteLine("Option not found");
                    Console.Read();
                    break;
            }
           
        }

    }
}
