using System.ComponentModel.DataAnnotations;

namespace TechnischeOpdrachtAutumn.Models
{
    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "User role is required.")]
        public UserRoleEnum? UserRole { get; set; }
    }

    public enum UserRoleEnum
    {
        Admin,
        User,
        Manager
    }

    public class Step1Model
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
    }

    public class Step2Model
    {
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class Step3Model
    {
        [Required(ErrorMessage = "User role is required.")]
        public UserRoleEnum? UserRole { get; set; }

        public bool ConsentNotifications { get; set; }
    }
}
