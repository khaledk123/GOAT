using DAL.Repository;
using DTOs.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomRepositories
{
    public class CategoryRepo:Repository<Category>
    {

        public Category GetByName(string name)
        {
            GoatContext goatContext = new GoatContext();
            return goatContext.Categories.FirstOrDefault(c => c.Name == name);
        }
    }
}
