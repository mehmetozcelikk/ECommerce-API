using ECommerce.Application.Repositories.Basket;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
{
    public BasketWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
