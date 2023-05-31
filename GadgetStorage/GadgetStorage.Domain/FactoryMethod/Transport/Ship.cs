using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;


namespace GadgetStorage.Domain.FactoryMethod.Transport
{
    public class Ship : ITransport
    {
        private readonly AbstractOrderStorage _orderStorage;

        public Ship(AbstractOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public void MakeDelivery(ParcelComponent parcel)
        {
            Console.WriteLine("\nParcel {0} was delivered using ship", parcel.GetHashCode());
        }
    }
}
