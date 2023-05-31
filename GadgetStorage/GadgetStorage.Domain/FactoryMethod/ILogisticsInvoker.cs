using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Entities.Enum;
using GadgetStorage.Domain.FactoryMethod.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.FactoryMethod
{
    public interface ILogisticsInvoker
    {
        void PrintDeliveryType();
        void invokeLogistics(ParcelComponent parcel, DeliveryType deliveryType);
    }
}
