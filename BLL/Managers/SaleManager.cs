using DAL.Repository;
using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public static class SaleManager
    {
        public static void Add(Sale sale) { 

            IRepository<Sale> repositorySale = new Repository<Sale>();
            IRepository<Product> repositoryProduct = new Repository<Product>();
            IRepository<Seller> repositorySeller = new Repository<Seller>();
            IRepository<Customer> repositoryCustomer = new Repository<Customer>();

           Product product = repositoryProduct.GetByID(sale.ProductId);
           Seller seller = repositorySeller.GetByID(sale.SellerId);

            if (product is not null && seller is not null) { 
                sale.Product = product;
                sale.Date = DateTime.Now;
                sale.IsExist = true;
                sale.Seller = seller;

            }
        }
    }
}
