using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Orderp
    {
        public virtual int id { get; set; }
        public virtual Supplier supplierno { get; set; }
        public virtual DateTime orderdate { get; set; }
        public virtual decimal amount { get; set; }
        public virtual DateTime deliverydate { get; set; }
        public virtual decimal cost { get; set; }
    }
}
