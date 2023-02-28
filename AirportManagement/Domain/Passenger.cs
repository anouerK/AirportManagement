using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
        [MinLength(3, ErrorMessage = " 3 chars min")]
        [MaxLength(25, ErrorMessage = " 3 chars min")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RegularExpression("@[1-9]{8}")]
        public string TelNumber { get; set; }

        public int PassportNumber { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Email must be valid")]
        public string EmailAdresse { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }
       /* bool CheckProfile(String nom,String prenom)
        {
            return (FirstName == prenom && LastName == nom);

        }
        bool CheckProfile(String nom, String prenom,String email)
        {
            return (FirstName == prenom && LastName == nom && EmailAdresse == email);

        }*/
        bool CheckProfile(String nom, String prenom, String? email)
        {
            return (FirstName == prenom && LastName == nom && EmailAdresse == email);

        }
        public virtual void  PassengerType()
        {
            Console.WriteLine(" I am Passenger");
        }

    }
}
