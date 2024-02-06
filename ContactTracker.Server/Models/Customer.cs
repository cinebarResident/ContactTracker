using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ContactTracker.Server.Models
{
    public class Customer
    {
        // ID* - 1-1
        [Key]
        public int CustomerID { get; set; }
        // FirstName* - 1-1
        [Required]
        public string FirstName { get; set; }
        // LastName* - 1-1
        [Required]
        public string LastName { get; set; }

        // Birthdate* - 1-1
        [Required]
        public DateTime Birthdate { get; set; }

        // Navigation property
        // PhoneNumber? - 0-n
        public ICollection<Phone> PhoneNumbers { get; set; }

        // Email? - 0-n
        public ICollection<Email> Emails { get; set; }

        // Address? - 0-n - 0-n
        public ICollection<CustomerAddress> Addresses { get; set; }
    }
}
