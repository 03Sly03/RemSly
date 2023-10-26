using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "FirstName must start with an Uppercase Letter !")]
        public string? FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "LastName start with an Uppercase Letter !")]
        public string? LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string? AvatarUrl { get; set; }
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
        //[PasswordValidator]   Voir selon délai si nous ajoutons le PasswordValidator
        public string? PassWord { get; set; }
        [Required]
        public bool IsAdmin { get; set; } = false;

        public List<Session>? Reservations_Sessions { get; set; }
        public List<Club>? Favorites_Clubs { get; set; }
        public List<Session>? Favorites_Sessions { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
    }

}
