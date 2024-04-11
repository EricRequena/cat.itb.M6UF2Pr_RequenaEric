using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using cat.itb.M6UF2Pr_RequenaEric.model;

namespace cat.itb.M6UF2Pr_RequenaEric
{
    public class OrderpMap : ClassMap<Orderp>
    {
        public OrderpMap()
        {
            Table("orderp");
            Id(x => x.id);
            References(x => x.supplierno).Column( "supplierno").Not.LazyLoad();
            Map(x => x.orderdate).Column( "orderdate");
            Map(x => x.amount).Column("amount");
            Map(x => x.deliverydate).Column( "deliverydate");
            Map(x => x.cost).Column("cost");
        }
    }
}
