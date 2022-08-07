using System.ComponentModel.DataAnnotations;

namespace AuthorizationandAuthentication.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        // userID from AspNetUser table
        public string? OwnerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public ContactStatus Status { get; set; }
    }
    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}