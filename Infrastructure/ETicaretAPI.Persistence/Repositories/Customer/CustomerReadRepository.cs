using ECommerce.Domain.Entities;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
