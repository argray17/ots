using System.ComponentModel.DataAnnotations;

namespace ots.Models
{
    public class Family
    {
        [Key]
        public uint FamilyId { get; set; }
        [Required]
        public string FamilyName { get; set; } = "DefaultFamilyName";

        ICollection<uint> FamilyMemberIds { get; set; } = new List<uint>();
        ICollection<uint> FamilyBusinessIds { get; set; } = new List<uint>();
        ICollection<Client> FamilyMembers { get; set; } = new List<Client>();
        ICollection<Business> FamilyBusinesses { get; set; } = new List<Business>();

    }
}
