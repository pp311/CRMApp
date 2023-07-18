using System.ComponentModel.DataAnnotations;
using Lab2.Enums;

namespace Lab2.DTOs.Account;

public class UpsertAccountDto
{
    [MaxLength((int)StringLength.Medium256)]
    public string? Name { get; set; }

    [EmailAddress]
    [MaxLength((int)StringLength.Medium256)]
    public string? Email { get; set; }

    [Phone]
    [MaxLength((int)StringLength.Short32)]
    public string? Phone { get; set; }

    [MaxLength((int)StringLength.Medium256)]
    public string? Address { get; set; }
}