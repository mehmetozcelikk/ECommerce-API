using ECommerce.Application.Repositories.Endpoint;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
{
    public EndpointWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
