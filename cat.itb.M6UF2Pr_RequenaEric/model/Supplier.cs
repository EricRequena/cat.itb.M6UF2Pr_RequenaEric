using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Supplier
    {
        internal IEnumerable<object> orders;

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string stcode { get; set; }
        public string zipcode { get; set; }
        public decimal area { get; set; }
        public string phone { get; set; }
        public int productno { get; set; }
        public decimal amount { get; set; }
        public decimal credit { get; set; }
        public string remark { get; set; }
    }
}
