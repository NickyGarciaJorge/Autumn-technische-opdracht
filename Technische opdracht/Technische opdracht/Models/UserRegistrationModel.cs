using System.ComponentModel.DataAnnotations;

namespace Technische_opdracht.Models
{
    public class UserRegistrationModel
    {
        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }

        public bool AcceptsNotifications { get; set; }
    }
}
