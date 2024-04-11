using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model
{
    public class Product
    {
        internal object supplierno;

        public int id { get; set; }
        public decimal code { get; set; }
        public string description { get; set; }
        public decimal currentstock { get; set; }
        public decimal minstock { get; set; }
        public decimal price { get; set; }
        public int empno { get; set; }
    }
}
