using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        public SaveState Add(T entity);
        public SaveState Update(T entity);
        public SaveState DeleteByID(int id);
        public List<T> GetAll();
        public T GetByID(int id);
        
    }
}
