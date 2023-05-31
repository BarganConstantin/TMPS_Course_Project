using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.SingletonServices.OrdersStorage
{
    public class InMemoryOrderStorage : AbstractOrderStorage
    {
        AbstractOrderSaveTemplate _storeOrder;

        public InMemoryOrderStorage(AbstractOrderSaveTemplate storeOrder) 
        {
            _storeOrder = storeOrder;
        }

        public override void AddOrder(IOrder order)
        {
            List<IOrder> orders = GetInstance();
            _storeOrder.Save(order, orders);
            orders.Add(order);
        }

        public override List<IOrder> GetOrdersList()
        {
            return GetInstance();
        }

        public override void RemoveOrder(IOrder order)
        {
            List<IOrder> orders = GetInstance();
            orders.Remove(order);
        }
    }
}
