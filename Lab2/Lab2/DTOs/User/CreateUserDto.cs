using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.User;

public class CreateUserDto
{
    [MaxLength((int)StringLength.Medium256)]
    public string Name { get; set; } = null!;
    
    [MaxLength((int)StringLength.Medium256)]
    public string Email { get; set; } = null!;
    
    public string Password { get; set; } = null!;
    
}