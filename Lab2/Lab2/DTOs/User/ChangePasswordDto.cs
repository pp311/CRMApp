using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.User;

public class ChangePasswordDto
{
    [MaxLength((int)StringLength.Medium256)]
    public string OldPassword { get; set; } = null!;
    
    [MaxLength((int)StringLength.Medium256)]
    public string NewPassword { get; set; } = null!;
}