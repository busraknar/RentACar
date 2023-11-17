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
    public class EmployeeManager :IEmployeeService<Employee>
    {
        IEmployeeDal _empdal;
        public EmployeeManager(IEmployeeDal empdal)
        {
            _empdal = empdal;
        }
        public void Add(Employee entity)
        {
            _empdal.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _empdal.Delete(entity);
        }

        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            return _empdal.Get(filter);
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            return _empdal.GetAll(filter);
        }

        public void Update(Employee entity)
        {
            _empdal.Update(entity);
        }
    }
}
