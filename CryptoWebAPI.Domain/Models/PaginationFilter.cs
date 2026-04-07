using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Domain.Models
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; } = 1; //page 
        public int PageSize { get; set; } = 10;

        public string? Search { get; set; } // filter by name/email
        public bool? IsActive { get; set; }
    }
}
