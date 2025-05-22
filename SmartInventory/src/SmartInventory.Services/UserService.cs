using SmartInventory.Core.DTOs;
using SmartInventory.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        public Task<AppUserRegistrationDTO> GetUserByEmailAsync(AppUserRegistrationDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<AppUserRegistrationDTO> RegisterAsync(AppUserRegistrationDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
