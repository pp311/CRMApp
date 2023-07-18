namespace Lab2.DTOs.Contact;

public class GetContactDto
{
    public int Id { get; set; }
    
    public int AccountId { get; set; }
    
    public string? AccountName { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
    
}