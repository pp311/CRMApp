using Lab2.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Lab2.Identity;

public class CustomUserManager : UserManager<User>
{
    public CustomUserManager(IUserStore<User> store,
             IOptions<IdentityOptions> optionsAccessor,
             IPasswordHasher<User> passwordHasher,
             IEnumerable<IUserValidator<User>> userValidators,
             IEnumerable<IPasswordValidator<User>> passwordValidators,
             ILookupNormalizer keyNormalizer,
             IdentityErrorDescriber errors,
             IServiceProvider services,
             ILogger<UserManager<User>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
    {
    }
}