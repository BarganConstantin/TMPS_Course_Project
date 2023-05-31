using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.FactoryMethod.Transport;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;

namespace GadgetStorage.Domain.FactoryMethod.Logistics
{
    public abstract class AbstractLogistics
    {
        public void MakeDelivery(ParcelComponent parcel)
        {
            ITransport transport = createTransport();
            transport.MakeDelivery(parcel);
        }
        public abstract ITransport createTransport();
    }
}
