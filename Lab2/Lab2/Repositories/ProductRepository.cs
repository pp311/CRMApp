using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(CRMDbContext context) : base(context)
        {
        }
    }
}
