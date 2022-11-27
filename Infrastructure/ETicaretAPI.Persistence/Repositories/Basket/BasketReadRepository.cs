using ECommerce.Application.Repositories.Basket;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
{
    public BasketReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
