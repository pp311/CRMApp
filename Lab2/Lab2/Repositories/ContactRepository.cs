using Lab2.Data;
using Lab2.Entities;
using Lab2.Repositories.Interfaces;

namespace Lab2.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(CRMDbContext context) : base(context)
        {
        }
    }
}
