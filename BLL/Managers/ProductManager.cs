using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs.Objects;
using DAL.Repository;
using DAL.CustomRepositories;
using DTOs;
using BLL.Utilities;
namespace BLL.Managers
{
    public static class ProductManager
    {
        private readonly static ProductRepo ProductRepo=new ProductRepo();
       
        public static SaveState Add(Product product)
        {
           
            product.Serial = SerialsMaker.SingleProductSerial();
           return ProductRepo.Add(product);
        }
        
        public static List<Product> GetAllWihInclude() {
            return ProductRepo.GetAllWithInclude();
        }

        public static List<Product> GetAll()
        {
            return ProductRepo.GetAll();
        }

        public static Product GetByID(int id) {
            return ProductRepo.GetByID(id);
        }

        public static Product GetByIdWithInclude(int id)
        {
            return ProductRepo.GetByIdWithInclude(id);
        }

        public static SaveState Update(Product product) {

           return ProductRepo.Update(product);
        }

        public static SaveState Delete(int id)
        {
           return ProductRepo.DeleteByID(id);
        }

    }
}
