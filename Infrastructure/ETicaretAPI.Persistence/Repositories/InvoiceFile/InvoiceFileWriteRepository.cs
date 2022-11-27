using ECommerce.Application.Repositories.InvoiceFile;
using ECommerce.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;

namespace ECommerceAPI.Persistence.Repositories;

public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
{
    public InvoiceFileWriteRepository(ECommerceAPIDbContext context) : base(context)
    {
    }
}
