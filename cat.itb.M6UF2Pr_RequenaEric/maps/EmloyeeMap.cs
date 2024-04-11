using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cat.itb.M6UF2Pr_RequenaEric.model;
using cat.itb.M6UF2Pr_RequenaEric.cruds;

namespace cat.itb.M6UF2Pr_RequenaEric;
    
    public class EmloyeeMap : ClassMap<Emloyee>
    {
        public EmloyeeMap()
        {
            Table("emp");
            Id(x => x.id);
            Map(x => x.surname);
            Map(x => x.job);
            Map(x => x.managerno);
            Map(x => x.startdate);
            Map(x => x.salary);
            Map(x => x.commission);
            Map(x => x.deptno);
        HasMany(x => x.products)
            .KeyColumn("empno")
            .Cascade.AllDeleteOrphan();
        }
    }
