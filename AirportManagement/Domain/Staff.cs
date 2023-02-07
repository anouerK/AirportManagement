using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployeEmentDate { get; set; }

        public string Function { get; set; }

        public float Salary { get; set; }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.Write(" I am Staff");
        }
    }
}

