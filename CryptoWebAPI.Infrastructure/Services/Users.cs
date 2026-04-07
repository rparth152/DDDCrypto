using CryptoWebAPI.Application.Interfaces;
using CryptoWebAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CryptoWebAPI.Infrastructure.Services
{
    public class Users : IUsers
    {
        ApplicationDBContext db;
        IMapper mapper;
        public Users(ApplicationDBContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<UsersDTO>> GetUsersAsync()
        {
            var users = db.Users.ToList();

            return mapper.Map<IEnumerable<UsersDTO>>(users);
        }
    }
}
