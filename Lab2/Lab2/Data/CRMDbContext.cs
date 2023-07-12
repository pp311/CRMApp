using Lab2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Data;

public class CRMDbContext : DbContext
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseLazyLoadingProxies();
    }

    public DbSet<Deal> Deals { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Lead> Leads { get; set; }
    public DbSet<DealProduct> DealProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Contact> Contacts { get; set; }
}