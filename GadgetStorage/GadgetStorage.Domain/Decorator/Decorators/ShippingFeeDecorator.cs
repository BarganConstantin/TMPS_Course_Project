using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator.Decorators
{
    public class ShippingFeeDecorator : OrderDecorator
    {
        private double _shippingFee;

        public ShippingFeeDecorator(IOrder order, double shippingFee)
            : base(order)
        {
            _shippingFee = shippingFee;
        }

        public override string GetDescription()
        {
            return string.Format($"{_order.GetDescription()}   Shipping Fee: {_shippingFee}$\n");
        }

        public override double CalculateCost()
        {
            return _order.CalculateCost() + _shippingFee;
        }
    }
}
