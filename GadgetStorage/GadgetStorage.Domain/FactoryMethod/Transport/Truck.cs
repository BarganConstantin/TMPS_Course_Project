using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.FactoryMethod.Transport
{
    public class Truck : ITransport
    {
        private readonly AbstractOrderStorage _orderStorage;

        public Truck(AbstractOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public void MakeDelivery(ParcelComponent parcel)
        {
            Console.WriteLine("\nParcel {0} was delivered using track", parcel.GetHashCode());
        }
    }
}
