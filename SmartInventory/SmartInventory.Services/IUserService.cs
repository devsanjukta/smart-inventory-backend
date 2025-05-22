using SmartInventory.Core.DTOs;
using SmartInventory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Services
{
    internal interface IUserService
    {
        public Task<AppUserResponseDTO> Register(AppUser user);
        public Task<AppUser> GetUserByEmail(string email);
    }
}
