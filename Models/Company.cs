using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mixerpa.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        [MaxLength(255)]
        public string CompanyName { get; set; }

    }
}
