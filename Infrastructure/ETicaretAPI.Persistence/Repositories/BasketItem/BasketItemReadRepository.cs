using ECommerce.Application.Repositories.BasketItem;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class BasketItemReadRepository : ReadRepository<BasketItem>, IBasketItemReadRepository
{
    public BasketItemReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
