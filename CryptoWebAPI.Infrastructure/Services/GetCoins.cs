using CryptoWebAPI.Application.Interfaces;
using CryptoWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Infrastructure.Services
{
    public class GetCoins : IGetCoins
    {
        public Task<List<CryptoMaster>> GetCoinsListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
