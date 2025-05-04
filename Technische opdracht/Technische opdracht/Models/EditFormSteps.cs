using System.ComponentModel.DataAnnotations;

namespace Technische_opdracht.Models
{
    public class Step1Model
    {
        [Required(ErrorMessage = "Gebruikersnaam is verplicht.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres.")]
        public string Email { get; set; }
    }

    public class Step2Model
    {
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Wachtwoorden komen niet overeen.")]
        public string ConfirmPassword { get; set; }
    }

    public class Step3Model
    {
        [Required]
        public UserRole Role { get; set; }
    }

    public class Step4Model
    {
        public bool AcceptsNotifications { get; set; }
    }

    public enum UserRole
    {
        Koper,
        Verhuurder,
        Beheerder
    }
}
