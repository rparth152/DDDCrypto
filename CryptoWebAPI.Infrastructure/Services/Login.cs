using CryptoWebAPI.Application.DTO;
using CryptoWebAPI.Application.Interfaces;
using CryptoWebAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Infrastructure.Services
{
    public class Login : ILogin
    {
        ApplicationDBContext db;
        public void LoginUser(ApplicationDBContext db)
        {
            this.db = db;
        }

        public string LoginUser(LoginDTO dto) {
            string Message = string.Empty;
            var email = db.Users.Where(x => x.Email == dto.Email).ToList();
            if (email != null) { 
                var pass = db.Users.Where(x => x.PassWord == dto.PassWord).ToList();
                if (pass != null) {
                    Message="Login Successfully";
                }
            }
            return Message;
        }

    }
}
