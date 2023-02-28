using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Range(0,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }

        public PlaneTypeEnum PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"Plane {{ {Capacity} {PlaneType} {ManuFactureDate} }}";
        }
        public Plane()
        {

        }
        public Plane(int capacite, DateTime manuFactureDate, PlaneTypeEnum planeType)
        {
            Capacity = capacite;
            ManuFactureDate = manuFactureDate;
            PlaneType = planeType;
        }
    }
}
