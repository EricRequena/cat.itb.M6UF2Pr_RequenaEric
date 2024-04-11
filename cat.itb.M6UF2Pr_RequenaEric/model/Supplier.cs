using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Supplier
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string address { get; set; }
        public virtual string city { get; set; }
        public virtual string stcode { get; set; }
        public virtual string zipcode { get; set; }
        public virtual decimal area { get; set; }
        public virtual string phone { get; set; }
        public virtual Product productno { get; set; }
        public virtual decimal amount { get; set; }
        public virtual decimal credit { get; set; }
        public virtual string remark { get; set; }
        public virtual ISet<Orderp> orders { get; set; }

    }
}
