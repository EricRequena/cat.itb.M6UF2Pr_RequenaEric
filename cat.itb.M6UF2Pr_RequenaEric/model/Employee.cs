using cat.itb.M6UF2Pr_RequenaEric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF2Pr_RequenaEric.model;

public class Employee
{
    public virtual int id { get; set; }
    public virtual string surname { get; set; }
    public virtual string job { get; set; }
    public virtual int managerno { get; set; }
    public virtual DateTime startdate { get; set; }
    public virtual decimal salary { get; set; }
    public virtual decimal commission { get; set; }
    public virtual int deptno { get; set; }
    public virtual ISet<Product> products { get; set; }
} 
