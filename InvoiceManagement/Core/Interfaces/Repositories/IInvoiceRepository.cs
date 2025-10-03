using InvoiceManagement.Core.Entities;

namespace InvoiceManagement.Core.Interfaces.Repositories
{
    public interface IInvoiceRepository
    {
        Task CreateInvoice(Invoice invoice);
        Task UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
        Task<Invoice> GetInvoiceById(int id);
        Task<ICollection<Invoice>> GetInvoices(); // TODO: Add filter
    }
}
