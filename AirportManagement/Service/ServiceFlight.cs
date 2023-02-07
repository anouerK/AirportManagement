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
        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            /*
            List<DateTime> dates = new List<DateTime>();
            foreach (Flight flight in Flights)
            {
                if(flight.Destination.Equals(destination))
                    dates.Add(flight.FlightDate);
            }*/
            // List<DateTime> dates = (List<DateTime>)(from f in Flights where f.Destination == destination select f.FlightDate);
            IEnumerable<DateTime> dates = (from f in Flights where f.Destination == destination select f.FlightDate);


            return dates;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            foreach (Flight flight in Flights)
            {

                switch (filterType)
                {
                    case "Destination":
                        if (flight.Destination.Equals(filterValue))
                            Console.WriteLine(flight);
                        break;
                    case "Departure":
                        if (flight.Departure.Equals(filterValue))
                            Console.WriteLine(flight);
                        break;
                    case "EstimatedDuration":
                        if (flight.EstimatedDuration == (int.Parse(filterValue)))
                            Console.WriteLine(flight);
                        break;
                    case "FlightDate":
                        if (flight.FlightDate == (DateTime.Parse(filterValue)))
                            Console.WriteLine(flight);
                        break;

                }
            }

        }
        public void ShowFlightDetails(Plane plane)
        {
            var flightss = from f in Flights where f.Plane == plane select new { f.FlightDate, f.Destination };
            foreach (var flight in flightss)
            {
                Console.WriteLine(flight);
            }
        }
        
    }

}
