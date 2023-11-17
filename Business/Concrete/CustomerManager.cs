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
    public class CustomerManager:ICustomerService<Customer>
    {
        ICustomerDal _cusdal;
        public CustomerManager(ICustomerDal cusdal)
        {
            _cusdal = cusdal;
        }
        public void Add(Customer entity)
        {
            _cusdal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _cusdal.Delete(entity);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _cusdal.Get(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _cusdal.GetAll(filter);
        }

        public void Update(Customer entity)
        {
            _cusdal.Update(entity);
        }
    }
}
