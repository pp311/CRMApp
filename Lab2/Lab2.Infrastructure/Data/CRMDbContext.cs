using Lab2.Domain.Entities;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Data;

public class CRMDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
{
    public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CRMDbContext).Assembly);
        modelBuilder.AddSeedData();
    }

    public DbSet<Deal> Deals { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Lead> Leads { get; set; }
    public DbSet<DealProduct> DealProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Contact> Contacts { get; set; }
}
