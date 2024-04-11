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
            Id(x => x.id, "id");
            Map(x => x.code, "code");
            Map(x => x.description, "description");
            Map(x => x.currentstock, "currentstock");
            Map(x => x.minstock, "minstock");
            Map(x => x.price, "price");
            References(x => x.supplierno, "supplierno").Not.LazyLoad();
            HasOne(x => x.supplierno)
                .PropertyRef("productno")
                .Cascade.All();
            

        }
    }
}
