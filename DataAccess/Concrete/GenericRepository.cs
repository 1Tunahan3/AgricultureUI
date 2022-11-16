using DataAccess.Abstract;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void AddT(T entity)
        {
            using var context= new AgricultureContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new AgricultureContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new AgricultureContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using var context = new AgricultureContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
