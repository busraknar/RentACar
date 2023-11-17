using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RentCar : IEntity
    {
        public int Id{ get; set; }
        public string CarId { get; set; }
        public string CustomerId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime RentDate { get; set; }


    }
}
