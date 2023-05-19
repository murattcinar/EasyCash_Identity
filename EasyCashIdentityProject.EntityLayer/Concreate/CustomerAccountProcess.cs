using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concreate
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessData { get; set; }
    }
}
