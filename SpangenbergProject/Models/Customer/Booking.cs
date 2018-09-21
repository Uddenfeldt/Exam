using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpangenbergProject.Models.Customer
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vänligen skriv in ert förnamn")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Vänligen skriv in ert efternamn")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Vänligen lägg in email, så vi vet hur vi skall kontakta er")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Vänligen säg vilken dag ni önskar träffa oss")]
        public DateTime Dtm { get; set; }
        [Required(ErrorMessage ="Vänligen välj tid ni önskar träffa oss")]
        public TimeSpan Tme { get; set; }
    }
}
