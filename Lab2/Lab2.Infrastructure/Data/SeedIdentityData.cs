using Bogus;
using Lab2.Application.Permissions;
using Lab2.Domain.Enums;
using Lab2.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Infrastructure.Data;

public static class SeedIdentityData
{
    public static void AddIdentitySeedData(this ModelBuilder modelBuilder)
    {
        var roles = GetDefaultRoles();
        foreach (var role in roles)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(role);
        }
        
        var superAdmin = GetSuperAdmin();
        modelBuilder.Entity<ApplicationUser>().HasData(superAdmin);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> {RoleId = roles[0].Id, UserId = superAdmin.Id});
        
        var admin = GetAdmin();
        modelBuilder.Entity<ApplicationUser>().HasData(admin);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> {RoleId = roles[1].Id, UserId = admin.Id});
        
        var users = new Faker<ApplicationUser>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 3)
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.UserName, (_, u) => u.Email)
            .Generate(10);

        foreach (var user in users)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(user);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> {RoleId = roles[2].Id, UserId = user.Id});
        }

        var permissionClaims = PermissionHelper.GetAllPermissions();
        int idx = 0;
        foreach (var claim in permissionClaims)
        {
            modelBuilder.Entity<IdentityRoleClaim<int>>().HasData(new IdentityRoleClaim<int> {Id = ++idx, RoleId = roles[0].Id, 
                ClaimType = CustomClaimTypes.Permission, ClaimValue = claim.Value});
            
            if (claim.Value.Contains("View") && !claim.Value.Contains("Role"))
            {
                modelBuilder.Entity<IdentityRoleClaim<int>>().HasData(new IdentityRoleClaim<int> {Id = ++idx, RoleId = roles[2].Id, 
                    ClaimType = CustomClaimTypes.Permission, ClaimValue = claim.Value});
            }
            
            if (!claim.Value.Contains("Role"))
            {
                modelBuilder.Entity<IdentityRoleClaim<int>>().HasData(new IdentityRoleClaim<int> {Id = ++idx, RoleId = roles[1].Id, 
                    ClaimType = CustomClaimTypes.Permission, ClaimValue = claim.Value});
            }
        }
    }

    private static List<ApplicationRole> GetDefaultRoles()
    {
        var roles = new List<ApplicationRole>
        {
            new() { Id = 1, Name = AppRole.SuperAdmin.ToString(), NormalizedName = AppRole.SuperAdmin.ToString().ToUpper() },
            new() { Id = 2, Name = AppRole.Admin.ToString(), NormalizedName = AppRole.Admin.ToString().ToUpper() },
            new() { Id = 3, Name = AppRole.User.ToString(), NormalizedName = AppRole.User.ToString().ToUpper() }
        };
        return roles;
    }

    private static ApplicationUser GetSuperAdmin()
    {
        return new ApplicationUser
        {
            Name = "superadmin",
            UserName = "superadmin@gmail.com",
            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
            Email = "superadmin@gmail.com",
            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
            EmailConfirmed = true,
            Id = 1,
            SecurityStamp = Guid.NewGuid().ToString(),
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null!, "Admin@123")
        };
    }

    private static ApplicationUser GetAdmin()
    {
        return new ApplicationUser
        {
            Name = "admin",
            UserName = "admin@gmail.com",
            NormalizedUserName = "ADMIN@GMAIL.COM",
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            EmailConfirmed = true,
            Id = 2,
            SecurityStamp = Guid.NewGuid().ToString(),
            PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null!, "Admin@123")
        };
    }
}