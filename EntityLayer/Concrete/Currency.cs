using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Currency
    {
        [Key]
        public int CurrencyID { get; set; }

        [StringLength(10)]
        public string sCurrencyCode { get; set; }

        [StringLength(50)]
        public string sCurrencyName { get; set; }

        [StringLength(5)]
        public string sCurrencySymbol { get; set; }
    }
}
