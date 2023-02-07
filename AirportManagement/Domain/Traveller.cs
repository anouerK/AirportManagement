using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }

        public string Nationalite { get; set; }
        public override void PassengerType()
        {
            Console.WriteLine(" I am Traveller");
        }
    }
}
