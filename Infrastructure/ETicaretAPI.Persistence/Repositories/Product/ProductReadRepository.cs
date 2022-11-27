using ECommerce.Domain.Entities;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
