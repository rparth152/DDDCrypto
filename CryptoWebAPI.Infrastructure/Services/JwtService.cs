using CryptoWebAPI.Infrastructure.Data;
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
        public async Task<LoginRespondModel>
    }
}
