namespace ContactTracker.Server.Models
{
    public class ContactAttempt
    {
        public int ContactAttemptId { get; set; } // Primary Key
        public int CustomerId { get; set; } // Foreign Key - links back to the Customer

        // Other properties
        public DateTime AttemptDate { get; set; }
        public string Notes { get; set; }

        // Navigation property for the many-to-one relationship
        public Customer Customer { get; set; }
    }
}
