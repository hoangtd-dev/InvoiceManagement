
using InvoiceManagement.Core.DTOs.Responses;

namespace InvoiceManagement.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserModel> GetUserById(int id);
    }
}
