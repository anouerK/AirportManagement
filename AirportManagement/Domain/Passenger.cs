using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int TelNumber { get; set; }

        public int PassportNumber { get; set; }
        public string EmailAdresse { get; set; }

        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }
       /* bool CheckProfile(String nom,String prenom)
        {
            return (FirstName == prenom && lastName == nom);

        }
        bool CheckProfile(String nom, String prenom,String email)
        {
            return (FirstName == prenom && lastName == nom && EmailAdresse == email);

        }*/
        bool CheckProfile(String nom, String prenom, String? email)
        {
            return (FirstName == prenom && lastName == nom && EmailAdresse == email);

        }

    }
}
