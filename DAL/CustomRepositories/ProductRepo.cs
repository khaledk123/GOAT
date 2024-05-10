using DAL.Repository;
using DTOs;
using DTOs.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomRepositories
{
    public class ProductRepo:Repository<Product>
    {
        private readonly GoatContext goatContext = new ();
        public List<Product> GetAllWithInclude() {
            return goatContext.Set<Product>().Include(p => p.Category).Where(p=>p.IsExist==true).ToList();
        }

        public Product GetByIdWithInclude(int id)
        {
            return goatContext.Set<Product>().Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

    }
}
