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
            Id(x => x.id, "id");
            Map(x => x.name, "name");
            Map(x => x.address, "address");
            Map(x => x.city, "city");
            Map(x => x.stcode, "stcode");
            Map(x => x.zipcode, "zipcode");
            Map(x => x.area, "area");
            Map(x => x.phone, "phone");
            References(x => x.productno, "productno").Not.LazyLoad();
            Map(x => x.amount, "amount");
            Map(x => x.credit, "credit");
            Map(x => x.remark, "remark");
            HasMany(x => x.orders)
                .KeyColumn("supplierno")
                .Cascade.AllDeleteOrphan();
        }
    }
}
