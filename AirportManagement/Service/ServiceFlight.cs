using AirportManagement.Domain;
using AirportManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  AirportManagement.Domain;


namespace AirportManagement.Service
{
    public class ServiceFlight : IServiceFlight
    {
        public ServiceFlight()
        {
            Flights = TestData.listFlights;
        }
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Flight flight in Flights)
            {
                if(flight.Destination.Equals(destination))
                    dates.Add(flight.FlightDate);
            }
            return dates;
        }
    }
}
