using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator.Decorators
{
    public class WarrantyDecorator : OrderDecorator
    {
        private double _warrantyPrice;

        public WarrantyDecorator(IOrder order, double warrantyPrice)
            : base(order)
        {
            _warrantyPrice = warrantyPrice;
        }

        public override string GetDescription()
        {
            return string.Format($"{_order.GetDescription()}   WarrantyPrice: {_warrantyPrice} $\n");
        }

        public override double CalculateCost()
        {
            return _order.CalculateCost() + _warrantyPrice;
        }
    }
}
