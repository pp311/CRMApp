using System.Security.Claims;
using Lab2.Domain.Entities;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Data;

public class CRMDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public CRMDbContext(DbContextOptions<CRMDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
    {
        _httpContextAccessor = httpContextAccessor;
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
    
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        AddMetaData();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void AddMetaData()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is AuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
        
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? "0";

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                ((AuditableEntity)entry.Entity).CreatedAt = DateTime.UtcNow;
                ((AuditableEntity)entry.Entity).CreatedBy = currentUserId;
            }
            ((AuditableEntity)entry.Entity).ModifiedAt = DateTime.UtcNow;
            ((AuditableEntity)entry.Entity).ModifiedBy = currentUserId;
        }
    }
}
