namespace Forms.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserProfile
    {
        [Required(ErrorMessage = "Please enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please provide an email address")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Please create a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please select a city")]
        public string? City { get; set; }

        public enum Cities { NewYork, LosAngeles, Chicago, Houston, Miami }
    }
}
