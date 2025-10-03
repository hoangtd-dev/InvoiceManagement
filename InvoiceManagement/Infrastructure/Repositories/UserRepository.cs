using InvoiceManagement.Core.Entities;
using InvoiceManagement.Core.Interfaces.Repositories;
using InvoiceManagement.Infrastructure.Data;

namespace InvoiceManagement.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private readonly AppDbContext _appDbContext;
        public UserRepository() { 
            //_appDbContext = appDbContext;
        }
        public async Task<User> GetUserById(int id)
        {
            return await Task.FromResult(new User());
        }
    }
}
