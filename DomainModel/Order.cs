using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Order
    {
        protected Order() { }

        public Order(string code)
        {
            Code = code;
        }

        public int Id { get; private set; }
        public string Code { get; private set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
