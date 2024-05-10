using DTOs;
using DTOs.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
            
      private readonly GoatContext goatContext = new();
        public SaveState Add(T entity)
        {
            try {
                goatContext.Add(entity);
                Save(goatContext);
                return SaveState.Success;
            }
            catch (Exception e) { 
                Console.Error.WriteLine(e.Message);
                return SaveState.Failed;
            }
        }

        public SaveState DeleteByID(int id)
        {
            try {
                var data = goatContext.Set<T>().Find(id);
                if (data is not null)
                {
                    data.IsExist = false;
                    goatContext.Update(data);
                    Save(goatContext);
                    return SaveState.Success;
                }
                return SaveState.Failed;
            } 
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message); 
                return SaveState.Failed;
            }
        }

        public List<T> GetAll()
        {
            var set = goatContext.Set<T>();
            if (set is null) {
                return null;
            }

            return set.ToList();
        }

        public SaveState Update(T entity)
        {
            try
            {
                    goatContext.Update(entity);
                    Save(goatContext);
                    return SaveState.Success;
                
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return SaveState.Failed;
            }
        }

        public void Save(GoatContext goatContext) {
            goatContext.SaveChanges();
        }

        public T GetByID(int id) {
           
            return goatContext.Set<T>().Find(id);
        }

       
    }
}
