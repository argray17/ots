using System.ComponentModel.DataAnnotations;

namespace ots.Models
{
    public class Staff
    {
        [Key]
        public uint StaffId { get; set; }

        [Required]
        [DisplayAttribute(Name = "First Name")]
        public string FirstName { get; set; } = "DefaultFirstName";

        [Required]
        [DisplayAttribute(Name = "Last Name")]
        public string LastName { get; set; } = "DefaultLastName";

        [DataType(DataType.PhoneNumber)]
        [DisplayAttribute(Name = "Primary Phone Number")]
        public string? PrimaryPhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayAttribute(Name = "Secondary Phone Number")]
        public string? SecondaryPhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayAttribute(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [DisplayAttribute(Name = "Street Address")]
        public string? StreetAddress { get; set; }

        [DisplayAttribute(Name = "City")]
        public string? CityAddress { get; set; }

        [DisplayAttribute(Name = "State")]
        public States? StateAddress { get; set; }

        [DataType(DataType.PostalCode)]
        [DisplayAttribute(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        //ICollection<uint>? ResolvedTicketIds { get; set; }
        //ICollection<uint>? UnresolvedTicketIds { get; set; }

        //ICollection<uint>? ResolvedCallLogEntryIds { get; set; }
        //ICollection<uint>? UnresolvedCallLogEntryIds { get; set; }

        //ICollection<Ticket>? ResolvedTickets { get; set; }
        //ICollection<Ticket>? UnresolvedTickets { get; set; }

        //ICollection<CallLogEntry>? ResolvedCallLogEntries { get; set; }
        //ICollection<CallLogEntry>? UnresolvedCallLogEntries { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetFullAddress()
        {
            return StreetAddress + ", " + CityAddress + ", " + StateAddress + " " + ZipCode;
        }

    }


}
