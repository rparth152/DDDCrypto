using CryptoWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Application.DTO
{
    public class CurrencyDTO
    {
        
        public int CurrencyId { get; set; }
        public string Currencyname { get; set; }
        public string Symbol { get; set; }
        public ICollection<CryptoMaster>? Cryptos { get; set; }
    }
}
