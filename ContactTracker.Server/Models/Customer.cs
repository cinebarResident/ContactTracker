namespace ContactTracker.Server.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // Primary key

        // Other properties
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Navigation property for relational data - one customer to many contact attempts
        public ICollection<ContactAttempt> ContactAttempts { get; set; }
    }
}
