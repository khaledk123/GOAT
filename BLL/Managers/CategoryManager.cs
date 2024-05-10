
using BLL.Utilities;
using DAL.CustomRepositories;
using DTOs.Objects;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public static class CategoryManager
    {
       private static readonly CategoryRepo categoryRepo = new CategoryRepo();

        public static SaveState Add(Category category)
        {
            return categoryRepo.Add(category);
        }

        public static List<Category> GetAll()
        {
            return categoryRepo.GetAll();
        }

        public static Category GetByID(int id)
        {
            return categoryRepo.GetByID(id);
        }

        public static SaveState Edit(Category category)
        {
            return categoryRepo.Update(category);
        }

        public static SaveState Delete(int id)
        {
            return categoryRepo.DeleteByID(id);
        }
    }
}
