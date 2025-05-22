using SmartInventory.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Services
{
    public interface IUserService
    {
        public Task<AppUserRegistrationDTO> RegisterAsync(AppUserRegistrationDTO userDTO);
        public Task<AppUserRegistrationDTO> GetUserByEmailAsync(AppUserRegistrationDTO user);
    }
}
