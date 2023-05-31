using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        public OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public abstract string GetDescription();

        public abstract double CalculateCost();
    }
}
