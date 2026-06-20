using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class RegistrationFormModel
{
    [Required(ErrorMessage = "Enter your name.")]
    [StringLength(100, ErrorMessage = "Name must not be longer than 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter your email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = string.Empty;
}
