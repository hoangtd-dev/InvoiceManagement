using InvoiceManagement.Core.Entities;

namespace InvoiceManagement.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
    }
}
