using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Application.Interfaces
{
    public interface IUsers
    {
        Task<IEnumerable<UsersDTO>> GetUsersAsync();
    }
}
