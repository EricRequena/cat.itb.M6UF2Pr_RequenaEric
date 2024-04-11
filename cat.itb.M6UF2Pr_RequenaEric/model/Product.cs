using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Product
    {
        public virtual int id { get; set; }
        public virtual decimal code { get; set; }
        public virtual string description { get; set; }
        public virtual decimal currentstock { get; set; }
        public virtual decimal minstock { get; set; }
        public virtual decimal price { get; set; }
        public virtual Employee empno { get; set; }
        public virtual Supplier supplierno { get; set; }
    }
}
