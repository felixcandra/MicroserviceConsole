using Microservice.Common.Interfaces;
using Microservice.Common.Interfaces.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.DataAccess.Model;
using Microservice.DataAccess.Param;

namespace Microservice.BussinessLogic.Service.Master
{
    public class SupplierService : iSupplierService
    {
        iSupplierRepository _supplierRepository = new SupplierRepository();
        bool status = false;

        public bool Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Id not found");
                Console.Read();
            }
            else if(id.ToString() == " ") {
                Console.WriteLine("Id is whitespace");
                Console.Read();
            }
            else{
                 
                status = _supplierRepository.Delete(id);
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {  
            return  _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            return _supplierRepository.Insert(supplierParam);
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {            
            return _supplierRepository.Update(supplierParam.Id, supplierParam);
        }
    }
}
