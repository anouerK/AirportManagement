// See https://aka.ms/new-console-template for more information
using AirportManagement.Domain;

Console.WriteLine("Hello, World!");
Plane plane = new Plane(100, new DateTime(2023, 1, 31), PlaneTypeEnum.BOING);
Plane plane2 = new Plane { Capacite = 100 };
Console.WriteLine(plane);