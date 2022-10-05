using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mixerpa.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string? Name { get; set; }
        [MaxLength(255)]
        public string? LastName { get; set; }
        [MaxLength(7)]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        public string? Biography { get; set; }
        public bool Disabled { get; set; } = false;
    }
}
