
using InvoiceManagement.Core.DTOs.Requests;
using InvoiceManagement.Core.DTOs.Responses;
using InvoiceManagement.Core.Entities;
using InvoiceManagement.Core.Interfaces.Repositories;
using InvoiceManagement.Core.Interfaces.Services;

namespace InvoiceManagement.Core.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository) {
            _invoiceRepository = invoiceRepository;
        }

        public async Task CreateInvoice(CreateInvoiceRequest invoice)
        {
            // TODO: Mapping
            await _invoiceRepository.CreateInvoice(new Invoice());
        }

        public async Task DeleteInvoice(int id)
        {
            await _invoiceRepository.DeleteInvoice(id);
        }

        public async Task<InvoiceModel> GetInvoiceById(int id)
        {
            var invoice = await _invoiceRepository.GetInvoiceById(id);

            // TODO: Mapping
            return new InvoiceModel();
        }

        public async Task<ICollection<InvoiceModel>> GetInvoices()
        {
            var invoices = await _invoiceRepository.GetInvoices();

            // TODO: Mapping
            return new List<InvoiceModel> { };
        }

        public async Task UpdateInvoice(UpdateInvoiceRequest invoice)
        {
            // TODO: Mapping
            await _invoiceRepository.UpdateInvoice(new Invoice());
        }
    }
}
