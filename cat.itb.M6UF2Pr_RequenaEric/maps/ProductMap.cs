using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using cat.itb.M6UF2Pr_RequenaEric.model;

namespace cat.itb.M6UF2Pr_RequenaEric
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("product");
            Id(x => x.id);
            Map(x => x.code).Column( "code");
            Map(x => x.description).Column( "description");
            Map(x => x.currentstock).Column( "currentstock");
            Map(x => x.minstock).Column("minstock");
            Map(x => x.price).Column("price");
            References(x => x.empno).Column("empno").Not.LazyLoad();
            HasOne(x => x.supplierno)
                .PropertyRef(nameof(Supplier.productno))
                .Not.LazyLoad()
                .Cascade.AllDeleteOrphan().Fetch.Join();

        }
    }
}
