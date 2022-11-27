using ECommerce.Application.Repositories.File;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class FileWriteRepository : WriteRepository<ECommerce.Domain.Entities.File>, IFileWriteRepository
{
    public FileWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
