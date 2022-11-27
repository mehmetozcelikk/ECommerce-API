using ECommerce.Application.Repositories.Endpoint;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class EndpointReadRepository : ReadRepository<Endpoint>, IEndpointReadRepository
{
    public EndpointReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
