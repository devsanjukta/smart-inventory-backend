using SmartInventory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Core.Interfaces
{
    public interface IUserRepository
    {
        public Task<AppUser> Register(AppUser user);
        public Task<AppUser> GetUserByEmail(string email);
    }
}
