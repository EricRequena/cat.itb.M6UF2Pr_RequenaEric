using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Orderp
    {
        public int id { get; set; }
        public int supplierno { get; set; }
        public DateTime orderdate { get; set; }
        public decimal amount { get; set; }
        public DateTime deliverydate { get; set; }
        public decimal cost { get; set; }
    }
}
