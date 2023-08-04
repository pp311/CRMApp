using Bogus;
using Lab2.Domain.Entities;
using Lab2.Domain.Enums;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Data;

public static class SeedData
{
    private const string ProductCodePrefix = "PRO-";
    private const int NumberOfProducts = 10;
    private const int RangeProductsPerDeal = 5;
    private const int NumberOfLeads = 30;
    private const int NumberOfDeals = NumberOfLeads;
    private const int NumberOfAccounts = 25;
    private const int NumberOfContacts = 100;
    private const int NumberOfUsers = 15;
    
    public static void AddSeedData(this ModelBuilder modelBuilder)
    {
        var accounts = new Faker<Account>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1)
            .RuleFor(a => a.Name, f => f.Company.CompanyName())
            .RuleFor(a => a.Address, f => f.Address.FullAddress())
            .RuleFor(a => a.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(a => a.Email, f => f.Internet.Email())
            .RuleFor(a => a.TotalSales, f => f.Random.Int(500, 50_000))
            .Generate(NumberOfAccounts);
        modelBuilder.Entity<Account>().HasData(accounts);

        var leads = new Faker<Lead>()
            .RuleFor(l => l.Id, f => f.IndexFaker + 1)
            .RuleFor(l => l.Title, f => f.Lorem.Sentence(3, 3))
            .RuleFor(l => l.Status, f => f.Random.Int(0, 3))
            .RuleFor(l => l.Description, f => f.Lorem.Sentence(10, 20))
            .RuleFor(l => l.Source, f => f.Random.Int(0, 4))
            .RuleFor(l => l.EstimatedRevenue, f => f.Random.Int(5000, 500_000))
            .RuleFor(l => l.EndedDate, (f, l) => l.Status >= 2 ? f.Date.Past() : null)
            .RuleFor(l => l.DisqualifiedReason, (f, l) => l.Status == (int)LeadStatus.Disqualified ? f.Random.Int(0, 4) : null)
            .RuleFor(l => l.DisqualifiedDescription, (f, l) => l.Status == (int)LeadStatus.Disqualified ? f.Lorem.Sentence(10, 20) : null)
            .RuleFor(l => l.AccountId, f => f.PickRandom(accounts).Id)
            .Generate(NumberOfLeads);
        modelBuilder.Entity<Lead>().HasData(leads);

        var products = new Faker<Product>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.ProductCode, f => ProductCodePrefix + f.Commerce.Ean8())
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Price, f => f.Random.Int(10, 1000))
            .RuleFor(p => p.Type, f => f.Random.Int(0, 1))
            .RuleFor(p => p.IsAvailable, () => true)
            .Generate(NumberOfProducts);
        modelBuilder.Entity<Product>().HasData(products);

        var deals = new Faker<Deal>()
            .RuleFor(d => d.Id, f => f.IndexFaker + 1)
            .RuleFor(d => d.Title, f => f.Lorem.Sentence(3, 3))
            .RuleFor(d => d.Description, f => f.Lorem.Sentence(10, 20))
            .RuleFor(d => d.Status, f => f.Random.Int(0, 2))
            .RuleFor(d => d.ActualRevenue, f => f.Random.Int(5000, 500_000))
            .RuleFor(d => d.LeadId, f => f.IndexFaker + 1)
            // .RuleFor(d => d.AccountId, f => f.Random.Int(1, NumberOfAccounts))
            .Generate(NumberOfDeals);
        modelBuilder.Entity<Deal>().HasData(deals);
        
        var dealProducts = new Faker<DealProduct>()
            .RuleFor(dp => dp.Id, f => f.IndexFaker + 1)
            .RuleFor(dp => dp.DealId, f => f.PickRandom(deals).Id)
            .RuleFor(dp => dp.ProductId, f => f.PickRandom(products).Id)
            .RuleFor(dp => dp.Quantity, f => f.Random.Int(1, 100))
            .RuleFor(dp => dp.PricePerUnit, f => f.Random.Int(10, 100))
            .Generate(RangeProductsPerDeal);
        modelBuilder.Entity<DealProduct>().HasData(dealProducts);
        
        var contacts = new Faker<Contact>()
            .RuleFor(c => c.Id, f => f.IndexFaker + 1)
            .RuleFor(c => c.Name, f => f.Name.FullName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.AccountId, f => f.PickRandom(accounts).Id)
            .Generate(NumberOfContacts);
        modelBuilder.Entity<Contact>().HasData(contacts);

        var users = new Faker<ApplicationUser>()
            // +2 because of the admin has id 1
            .RuleFor(u => u.Id, f => f.IndexFaker + 2)
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.UserName, (f, u) => u.Email)
            .RuleFor(u => u.PasswordHash, () => new PasswordHasher<object>().HashPassword(null!, "Admin@123"))
            .RuleFor(u => u.SecurityStamp, () => Guid.NewGuid().ToString())
            .Generate(NumberOfUsers);
        modelBuilder.Entity<ApplicationUser>().HasData(users);

        foreach (var usersRole in users)
        {
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> {UserId =  usersRole.Id, RoleId = 2});
        }
    }
}
