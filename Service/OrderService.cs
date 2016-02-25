using DatabaseContext.Contracts;
using DomainModel;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService : IOrderService
    {
        private IOrdersRepository _ordersRepo;

        public OrderService(IOrdersRepository ordersRepo)
        {
            _ordersRepo = ordersRepo;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _ordersRepo.GetAll();
        }
    }
}
