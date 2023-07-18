using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.Contact;

public class UpsertContactDto
{
    public int AccountId { get; set; }

    [MaxLength((int)StringLength.Medium256)]
    public string Name { get; set; } = null!;

    [EmailAddress]
    [MaxLength((int)StringLength.Medium256)]
    public string Email { get; set; } = null!;

    [Phone]
    [MaxLength((int)StringLength.Short32)]
    public string? Phone { get; set; }
}
