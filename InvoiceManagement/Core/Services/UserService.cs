
using InvoiceManagement.Core.DTOs.Responses;
using InvoiceManagement.Core.Interfaces.Repositories;
using InvoiceManagement.Core.Interfaces.Services;

namespace InvoiceManagement.Core.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) { 
            _userRepository = userRepository;
        }
        public async Task<UserModel> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);

            // TODO: Mapping
            return new UserModel();
        }
    }
}
