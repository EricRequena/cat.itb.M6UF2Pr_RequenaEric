using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Mapping;
using cat.itb.M6UF2Pr_RequenaEric.model;

namespace cat.itb.M6UF2Pr_RequenaEric
{
    public class SupplierMap : ClassMap<Supplier>
    {
        public SupplierMap()
        {
            Table("supplier");
            Id(x => x.id);
            Map(x => x.name).Column("name");
            Map(x => x.address).Column( "address");
            Map(x => x.city).Column( "city");
            Map(x => x.stcode).Column( "stcode");
            Map(x => x.zipcode).Column( "zipcode");
            Map(x => x.area).Column("area");
            Map(x => x.phone).Column( "phone");
            References(x => x.productno).Column( "productno").Not.LazyLoad();
            Map(x => x.amount).Column( "amount");
            Map(x => x.credit).Column( "credit");
            Map(x => x.remark).Column( "remark");
            HasMany(x => x.orders)
                .KeyColumn("supplierno")
                .Cascade.AllDeleteOrphan();
        }
    }
}
