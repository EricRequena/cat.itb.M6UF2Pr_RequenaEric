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
            Id(x => x.id, "id");
            References(x => x.supplierno, "supplierno").Not.LazyLoad();
            Map(x => x.supplierno, "supplierno");
            Map(x => x.orderdate, "orderdate");
            Map(x => x.amount, "amount");
            Map(x => x.deliverydate, "deliverydate");
            Map(x => x.cost, "cost");
        }
    }
}
