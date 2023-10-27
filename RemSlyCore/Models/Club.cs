using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Models
{
    public class Club
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        //public string Description { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? PostalCode { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        public string? PhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        public string? OpeningHours { get; set; }
        public List<Session>? Sessions { get; set; }
        public List<Material>? Materials { get; set; }
        public bool IsLadiesOnly { get; set; }
        public bool Is24h { get; set; }
    }
}
