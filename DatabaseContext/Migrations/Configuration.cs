namespace DatabaseContext.Migrations
{
    using DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext.OrdersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DatabaseContext.OrdersContext";
        }

        protected override void Seed(DatabaseContext.OrdersContext context)
        {
            var defaultStandards = new List<Order>();

            defaultStandards.Add(new Order("ABCDE", DateTime.Now));

            foreach (var order in defaultStandards)
                context.Orders.AddOrUpdate(order);
        }
    }
}
