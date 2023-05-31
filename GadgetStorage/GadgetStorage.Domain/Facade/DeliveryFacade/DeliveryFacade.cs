using GadgetStorage.Domain.Adapter;
using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Entities.Enum;
using GadgetStorage.Domain.Facade.PackFacade;
using GadgetStorage.Domain.FactoryMethod;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.DeliveryFacade
{
    public class DeliveryFacade : IDeliveryFacade
    {
        private readonly IPackFacade _packFacade;
        private readonly ILogisticsInvoker _logisticsInvoker;

        public DeliveryFacade(IPackFacade packFacade, ILogisticsInvoker logisticsInvoker) 
        { 
            _packFacade = packFacade;
            _logisticsInvoker = logisticsInvoker;
        }

        public void DeliverOrder()
        {
            var parcel = _packFacade.CreateParcelForDelivery();
            DeliverParcel(parcel);
        }

        public void DeliverParcel(ParcelComponent parcel)
        {
            Console.Clear();
            _logisticsInvoker.PrintDeliveryType();
            var option = Console.ReadLine();
            
            DeliveryType deliveryType = (DeliveryType)Enum.GetValues(typeof(DeliveryType)).GetValue(Convert.ToInt32(option));

            _logisticsInvoker.invokeLogistics(parcel, deliveryType);

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadLine();
        }
    }
}
