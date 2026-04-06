using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Domain.Models
{
    public class CryptoMaster
    {
        [Key]
        public int CryptoId { get; set; }

        [Required, StringLength(30)]
        public string CryptoName { get; set; }

        [Required, StringLength(30)]
        public string Symbol { get; set; }

        [Required, StringLength(30)]
        public string CoinGeckoId { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastSyncedAt { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

    }
}
