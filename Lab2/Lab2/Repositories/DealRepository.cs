using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class DealRepository : RepositoryBase<Deal>, IDealRepository
    {
        public DealRepository(CRMDbContext context) : base(context)
        {
        }
    }
}
