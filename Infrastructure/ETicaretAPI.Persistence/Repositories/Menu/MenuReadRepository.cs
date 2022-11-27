using ECommerce.Application.DTOs.Configuration;
using ECommerce.Application.Repositories.Menu;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class MenuReadRepository : ReadRepository<ECommerce.Domain.Entities.Menu>, IMenuReadRepository
{
    public MenuReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
