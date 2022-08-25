using System.ComponentModel.DataAnnotations;

namespace ots.Models
{
    public class Ticket
    {
        [Key]
        public uint TicketId { get; set; }
        public uint? BusinessId { get; set; }
        public Business? Business { get; set; }
        public uint? ClientId { get; set; }
        public Client? Client { get; set; }
        public uint? FamilyId { get; set; }
        public Family? Family { get; set; }
        public uint? StaffId { get; set; }
        public Staff? Staff { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public uint CreationDate { get; set; }

        [DataType(DataType.Date)]
        public uint DueDate { get; set; }


        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        [Required]
        public bool IsResolved { get; set; } = false;

        public IType IssueType { get; set; } = IType.GeneralInquiry;
        public IPriority IssuePriority { get; set; } = IPriority.Low;
        public enum IType
        {
            Audit,
            Billing,
            Bookkeeping,
            Licensing,
            FinancialStatement,
            GeneralInquiry,
            Payroll,
            Scheduling,
            TaxNotice,
            TaxReturn
        }
        public enum IPriority
        {
            Low,
            Medium,
            High
        }
    }
}
