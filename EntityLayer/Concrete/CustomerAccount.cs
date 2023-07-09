using EntityLayer.Concrete.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        [Key]
        public int CustomerAccountID { get; set; }

        [StringLength(10)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string AccountIban { get; set; }
        public decimal AccountBalance { get; set; }
        [StringLength(50)]
        public string? BankBranch { get; set; }
        public Currency? Currency { get; set; }
        [ForeignKey(nameof(Currency))]
        public int? pCurrencyID { get; set; }
        public int? AppUserID { get; set; }

        public AppUser?  AppUser { get; set; }
    }
}
