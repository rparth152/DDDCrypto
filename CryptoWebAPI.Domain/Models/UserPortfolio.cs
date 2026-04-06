using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Domain.Models
{
    public class UserPortfolio
    {
        [Key]
        public int PortFolioId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CryptoId { get; set; }

        [ForeignKey("UserId")]
        public UserMaster User { get; set; }

        [ForeignKey("CryptoId")]
        public CryptoMaster Crypto { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal AvgBuyPrice { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal TotalInvestment { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

    }
}
