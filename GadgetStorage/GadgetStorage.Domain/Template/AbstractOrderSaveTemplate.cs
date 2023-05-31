using GadgetStorage.Domain.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Template
{
    public abstract class AbstractOrderSaveTemplate
    {
        public void Save(IOrder order, List<IOrder> orders)
        {
            if (beforeSave(order, orders))
            {
                orders.Add(order);

                afterSave(order);
            }
            else
            {
                failedSave(order);
            }
        }

        protected abstract bool beforeSave(IOrder order, List<IOrder> orders);
        protected abstract void afterSave(IOrder order);
        protected abstract void failedSave(IOrder order);
    }
}
