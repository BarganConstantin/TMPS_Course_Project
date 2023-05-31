using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;

namespace GadgetStorage.Domain.FactoryMethod.Transport

{
    public class Plane : ITransport
    {
        private readonly AbstractOrderStorage _orderStorage;

        public Plane(AbstractOrderStorage orderStorage) 
        { 
            _orderStorage = orderStorage;
        }

        public void MakeDelivery(ParcelComponent parcel)
        {
            Console.WriteLine("\nOrder {0} was delivered using plane", parcel.GetHashCode());
        }
    }
}
