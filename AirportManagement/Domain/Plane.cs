using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public enum PlaneTypeEnum
    {
        BOING,
        AIRBUS
    }
    public class Plane
    {
        public int PlaneId { get; set; }
        public int Capacite { get; set; }
        public DateTime ManuFactureDate { get; set; }

        public PlaneTypeEnum PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"Plane {{ {Capacite} {PlaneType} {ManuFactureDate} }}";
        }
        public Plane()
        {

        }
        public Plane(int capacite, DateTime ManuFactureDate, PlaneTypeEnum planeType)
        {
            Capacite = capacite;
            ManuFactureDate = ManuFactureDate;
            PlaneType = planeType;
        }
    }
}
