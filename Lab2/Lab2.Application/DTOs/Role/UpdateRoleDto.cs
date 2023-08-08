using System.ComponentModel.DataAnnotations;
using Lab2.Domain.Enums;

namespace Lab2.Application.DTOs.Role;

public class UpdateRoleDto
{
    [Required]
    [MaxLength((int)StringLength.Medium256)]
    public string Name { get; set; } = null!;
    
    public List<string> Permissions { get; set; } = null!;
}