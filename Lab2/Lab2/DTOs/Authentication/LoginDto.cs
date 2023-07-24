using System.ComponentModel.DataAnnotations;

namespace Lab2.DTOs.Authentication;

public class LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    
    [Required]
    public string Password { get; set; } = null!;
}