using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.SingletonServices.OrdersStorage
{
    public abstract class AbstractOrderStorage
    {
        private static List<IOrder> _orders;
        private static readonly object padlock = new object();

        static AbstractOrderStorage() { }

        protected static List<IOrder> GetInstance()
        {
            if (_orders == null)
            {
                lock (padlock)
                {
                    if (_orders == null)
                    {
                        _orders = new List<IOrder>();
                    }
                }
            }
            return _orders;
        }

        public abstract List<IOrder> GetOrdersList();
        public abstract void AddOrder(IOrder order);
        public abstract void RemoveOrder(IOrder order);
    }
}
