using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        public readonly IServiceDal serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void AddT(Service entity)
        {
            serviceDal.AddT(entity);
        }

        public void Delete(Service entity)
        {
            serviceDal.Delete(entity);
        }

        public List<Service> GetAll()
        {
           return serviceDal.GetAll();
        }

        public Service GetById(int id)
        {
           return serviceDal.GetById(id);
        }

        public void Update(Service entity)
        {
            serviceDal.Update(entity);
        }
    }
}
