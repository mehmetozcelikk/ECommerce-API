using ECommerce.Application.Repositories.InvoiceFile;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
{
    public InvoiceFileReadRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
