using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> where T : class,new()
    {
        public void AddT(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public List<T> GetAll();
        public T GetById(int id);
    }
}
