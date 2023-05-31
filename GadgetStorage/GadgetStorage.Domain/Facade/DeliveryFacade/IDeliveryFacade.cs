using GadgetStorage.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.DeliveryFacade
{
    public interface IDeliveryFacade
    {
        public void DeliverOrder();
        public void DeliverParcel(ParcelComponent parcel);
    }
}
