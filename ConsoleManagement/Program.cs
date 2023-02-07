// See https://aka.ms/new-console-template for more information
using AirportManagement.Domain;
using AirportManagement.Service;

Console.WriteLine("Hello, World!");
Plane plane = new Plane(100, new DateTime(2023, 1, 31), PlaneTypeEnum.BOING);
Plane plane2 = new Plane { Capacity = 100 };
Console.WriteLine(plane);
Passenger passenger = new Passenger();
passenger.PassengerType();
Staff staff = new Staff();
staff.PassengerType();
Traveller traveller = new Traveller();
traveller.PassengerType();
Console.WriteLine("********** TP2  **********");
ServiceFlight serviceFlight = new ServiceFlight();
//Console.WriteLine(serviceFlight.GetFlightDates("Paris"));
foreach (DateTime flight in serviceFlight.GetFlightDates("Paris"))
{
   Console.WriteLine(flight);
}
