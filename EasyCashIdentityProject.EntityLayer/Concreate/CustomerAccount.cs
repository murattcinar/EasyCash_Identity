using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concreate
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public int CustomerAccountnumber { get; set; }
        public string CustomerAccountCurrency { get; set; }
        public decimal CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }
    }
}
