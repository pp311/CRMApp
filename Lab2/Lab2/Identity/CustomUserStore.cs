using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Lab2.Identity;
public class CustomUserStore : IUserStore<User>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public CustomUserStore(IUnitOfWork unitOfWork, IUserRepository userRepository)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public Task<string> GetUserIdAsync(User user,
                                       CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetUserNameAsync(User user,
                                          CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetUserNameAsync(User user,
                                 string? userName,
                                 CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetNormalizedUserNameAsync(User user,
                                                    CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetNormalizedUserNameAsync(User user,
                                           string? normalizedName,
                                           CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        _userRepository.Add(user);
        _unitOfWork.SaveChangesAsync();
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<IdentityResult> UpdateAsync(User user,
                                            CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> DeleteAsync(User user,
                                            CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindByIdAsync(string userId,
                                     CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindByNameAsync(string normalizedUserName,
                                       CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    // Implement other IUserStore methods here
    public void Dispose()
    {
        // TODO release managed resources here
    }
}
