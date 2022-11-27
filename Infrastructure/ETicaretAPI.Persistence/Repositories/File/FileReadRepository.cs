using ECommerce.Application.Repositories.File;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class FileReadRepository : ReadRepository<ECommerce.Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
