using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(CRMDbContext context) : base(context)
        {
        }
    }
}
