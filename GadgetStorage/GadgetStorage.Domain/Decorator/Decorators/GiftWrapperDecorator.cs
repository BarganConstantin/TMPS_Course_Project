using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator.Decorators
{
    public class GiftWrapperDecorator : OrderDecorator
    {
        private double _giftWrappingFee;

        public GiftWrapperDecorator(IOrder order, double giftWrappingFee)
            : base(order)
        {
            _giftWrappingFee = giftWrappingFee;
        }
        public override string GetDescription()
        {
            return string.Format($"{_order.GetDescription()}   Gift Wrapping Fee: {_giftWrappingFee}$\n");
        }

        public override double CalculateCost()
        {
            return _order.CalculateCost() + _giftWrappingFee;
        }
    }
}
