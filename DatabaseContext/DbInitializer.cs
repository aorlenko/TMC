using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
    public class DbInitializer : CreateDatabaseIfNotExists<OrdersContext>
    {
        protected override void Seed(OrdersContext context)
        {
            

            base.Seed(context);
        }
    }
}
