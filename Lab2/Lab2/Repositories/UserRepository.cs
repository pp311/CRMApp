using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(CRMDbContext context) : base(context)
    {
    }
}