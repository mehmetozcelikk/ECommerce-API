using ECommerce.Application.Repositories.BasketItem;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
{
    public BasketItemWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
