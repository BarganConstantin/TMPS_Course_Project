using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Template
{
    public class BasicStoreOrderLogic : AbstractOrderSaveTemplate
    {
        protected override void afterSave(IOrder order)
        {
            Console.WriteLine($"Success save order with ID: {order.GetHashCode()} in orders list!");
        }

        protected override bool beforeSave(IOrder order, List<IOrder> orders)
        {
            return !orders.Contains(order);
        }

        protected override void failedSave(IOrder order)
        {
            Console.WriteLine($"Error save order with ID: {order.GetHashCode()} in orders list!");
        }
    }
}