using InvoiceManagement.Core.Entities;
using InvoiceManagement.Core.Interfaces.Repositories;
using InvoiceManagement.Infrastructure.Data;

namespace InvoiceManagement.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        //private readonly AppDbContext _appDbContext;
        public InvoiceRepository() { 
            //_appDbContext = appDbContext;
        }
        public async Task CreateInvoice(Invoice invoice)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteInvoice(int id)
        {
            await Task.CompletedTask;
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await Task.FromResult(new Invoice());
        }

        public async Task<ICollection<Invoice>> GetInvoices()
        {
            return await Task.FromResult(new List<Invoice> { });
        }

        public async Task UpdateInvoice(Invoice invoice)
        {
            await Task.CompletedTask;
        }
    }
}
