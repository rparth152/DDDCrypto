using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Domain.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }

        [Required, StringLength(20)]
        public string Currencyname { get; set; }

        [Required, StringLength(5)]
        public string Symbol { get; set; }

        public ICollection<CryptoMaster>? Cryptos { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

    }
}
