using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cat.itb.M6UF2Pr_RequenaEric.model;
using cat.itb.M6UF2Pr_RequenaEric.cruds;

namespace cat.itb.M6UF2Pr_RequenaEric;
    
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("employee");
            Id(x => x.id);
            Map(x => x.surname).Column("surname");
            Map(x => x.job).Column("job");
            Map(x => x.managerno).Column("managerno");
            Map(x => x.startdate).Column("startdate");
            Map(x => x.salary).Column("salary");
            Map(x => x.commission).Column("commission");
            Map(x => x.deptno).Column("deptno");
        HasMany(x => x.products)
            .KeyColumn("empno")
            .Cascade.AllDeleteOrphan();
        }
    }
