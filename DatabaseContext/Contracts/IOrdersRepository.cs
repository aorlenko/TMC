using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext.Contracts
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> GetAll();
    }
}
