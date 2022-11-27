using ECommerce.Application.Repositories.Menu;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class MenuWriteRepository : WriteRepository<ECommerce.Domain.Entities.Menu>, IMenuWriteRepository
{
    public MenuWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
