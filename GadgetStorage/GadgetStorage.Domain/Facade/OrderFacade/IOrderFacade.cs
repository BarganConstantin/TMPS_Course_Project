using GadgetStorage.Domain.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.OrderFacade
{
    public interface IOrderFacade
    {
        void RegisterOrder();
        void RemoveOrder(IOrder order);
        void PrintOrders();
    }
}
