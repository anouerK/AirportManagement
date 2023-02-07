using AirportManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Interface
{
    public interface IServiceFlight
    {
        public IEnumerable<DateTime> GetFlightDates(string destination);


    }
}
