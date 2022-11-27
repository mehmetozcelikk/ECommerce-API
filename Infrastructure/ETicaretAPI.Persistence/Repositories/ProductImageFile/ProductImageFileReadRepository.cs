using ECommerce.Application.Repositories.ProductImageFile;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
{
    public ProductImageFileReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
