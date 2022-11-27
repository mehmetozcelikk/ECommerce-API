using ECommerce.Domain.Entities;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
