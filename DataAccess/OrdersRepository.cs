using DataAccess.Contracts;
using DatabaseContext;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrdersRepository:IOrdersRepository
    {
        public IEnumerable<Order> GetAll()
        {
            using (var db = new OrdersContext())
            {
                return db.Orders.ToList();
            }
        }
    }
}
