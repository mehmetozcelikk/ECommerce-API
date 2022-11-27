using ECommerce.Application.Repositories.ProductImageFile;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
{
    public ProductImageFileWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
