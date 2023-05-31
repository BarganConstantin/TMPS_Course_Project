using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.FactoryMethod.Transport
{
    public interface ITransport
    {
        void MakeDelivery(ParcelComponent parcel);
    }
}
