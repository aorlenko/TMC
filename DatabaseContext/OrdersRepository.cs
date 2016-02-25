using DatabaseContext.Contracts;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
    public class OrdersRepository:IOrdersRepository
    {
        public IEnumerable<Order> GetAll()
        {
            using (var db = new OrdersContext())
            {
                return db.Set<Order>().ToList();
            }
        }
    }
}
