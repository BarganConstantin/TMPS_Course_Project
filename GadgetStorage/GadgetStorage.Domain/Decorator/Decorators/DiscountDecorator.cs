using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator.Decorators
{
    public class DiscountDecorator : OrderDecorator
    {
        private double _discountPercentage;

        public DiscountDecorator(IOrder order, double discountPercentage)
            : base(order)
        {
            _discountPercentage = discountPercentage;
        }

        public override string GetDescription()
        {
            return string.Format($"{_order.GetDescription()}   Discount: {_discountPercentage}%\n");
        }

        public override double CalculateCost()
        {
            return _order.CalculateCost() * (1 - _discountPercentage / 100);
        }
    }
}
