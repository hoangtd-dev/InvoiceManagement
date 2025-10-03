
using InvoiceManagement.Core.DTOs.Requests;
using InvoiceManagement.Core.DTOs.Responses;

namespace InvoiceManagement.Core.Interfaces.Services
{
    public interface IInvoiceService
    {
        Task CreateInvoice(CreateInvoiceRequest invoice);
        Task UpdateInvoice(UpdateInvoiceRequest invoice);
        Task DeleteInvoice(int id);
        Task<InvoiceModel> GetInvoiceById(int id);
        Task<ICollection<InvoiceModel>> GetInvoices(); // TODO: Add filter
    }
}
