using CryptoWebAPI.Application.DTO;
using CryptoWebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Infrastructure.Services
{
    public class JwtService
    {
        private readonly ApplicationDBContext db;
        private readonly IConfiguration configuration;
        public JwtService(ApplicationDBContext dBContext , IConfiguration configuration) {
            this.db = db;
            this.configuration = configuration; 
        }
        public async Task<LoginDTO> Authenticate(LoginDTO dto) {
            if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.PassWord))
                return null;
            var useraccount = await db.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (useraccount is null || !PasswordHashHandler.VerifyPassword(dto.PassWord, useraccount.PassWord))
                return null;
                    }
    }
}
