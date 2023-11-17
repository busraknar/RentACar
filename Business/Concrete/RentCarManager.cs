using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentCarManager:IRentCarService<RentCar>
    {
        IRentCarDal _rentdal;
        public RentCarManager(IRentCarDal rentdal)
        {
            _rentdal = rentdal;
        }
        public void Add(RentCar entity)
        {
            _rentdal.Add(entity);
        }

        public void Delete(RentCar entity)
        {
            _rentdal.Delete(entity);
        }

        public RentCar Get(Expression<Func<RentCar, bool>> filter)
        {
            return _rentdal.Get(filter);
        }

        public List<RentCar> GetAll(Expression<Func<RentCar, bool>> filter = null)
        {
            return _rentdal.GetAll(filter);
        }

        public List<RentCarDetailDto> GetDetails()
        {

            return _rentdal.GetDetails();
        }


        public void Update(RentCar entity)
        {
            _rentdal.Update(entity);
        }
    }
}
