using System.ComponentModel.DataAnnotations;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.User;

public class UpdateUserDto
{
    [MaxLength((int)StringLength.Medium256)]
    public string Name { get; set; } = null!;
    
    [EmailAddress]
    [MaxLength((int)StringLength.Medium256)]
    public string Email { get; set; } = null!;
}