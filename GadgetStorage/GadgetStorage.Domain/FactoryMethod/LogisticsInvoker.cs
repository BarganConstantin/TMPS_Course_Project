using Autofac;
using GadgetStorage.Domain.Adapter;
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
    public class LogisticsInvoker : ILogisticsInvoker
    {
        private readonly ILifetimeScope _container;
        private readonly IConsolePrintUtils _consolePrintUtils;

        public LogisticsInvoker(ILifetimeScope container, IConsolePrintUtils consolePrintUtils) 
        {
            _container = container;
            _consolePrintUtils = consolePrintUtils;
        }

        public void invokeLogistics(ParcelComponent parcel, DeliveryType deliveryType)
        {
            AbstractLogistics logistics = _container.ResolveNamed<AbstractLogistics>(deliveryType.ToString());
            logistics.MakeDelivery(parcel);
        }

        public void PrintDeliveryType()
        {
            _consolePrintUtils.PrintOnCenterWithColour("Choosing logistics type");
            Console.WriteLine();

            int position = 0;
            foreach (var logistic in Enum.GetValues(typeof(DeliveryType)))
            {
                _consolePrintUtils.PrintWithColour($" {position} - {logistic} logistics\n", ConsoleColor.DarkBlue);
                position++;
            }

            Console.WriteLine();

            _consolePrintUtils.PrintEmptyColourLine();
            _consolePrintUtils.PrintWithColour("\nSelect option: ");
        }
    }
}
