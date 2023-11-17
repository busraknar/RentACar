using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService<Car>
    {
        ICarDal _cardal;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }
        public void Add(Car entity)
        {
           _cardal.Add(entity);
        }

        public void Delete(Car entity)
        {
            _cardal.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cardal.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cardal.GetAll(filter);
        }

        public void Update(Car entity)
        {
            _cardal.Update(entity);
        }
    }
}
