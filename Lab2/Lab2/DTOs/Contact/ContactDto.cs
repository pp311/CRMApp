using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.Contact;

public class ContactDto
{
    public int Id { get; set; }

    [MaxLength((int)StringLength.Medium256)]
    public string Name { get; set; } = null!;

    [MaxLength((int)StringLength.Medium256)]
    public string Email { get; set; } = null!;

    [MaxLength((int)StringLength.Short32)]
    public string? Phone { get; set; }
}
