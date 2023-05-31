using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Facade.DeliveryFacade;
using GadgetStorage.Domain.FactoryMethod.Logistics;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Client.Command.Commands
{
    public class DeliverOrderCommand : ICommand
    {
        private readonly IDeliveryFacade _deliveryFacade;
        public DeliverOrderCommand(IDeliveryFacade deliveryFacade) 
        { 
            _deliveryFacade = deliveryFacade;
        }
        public void Execute()
        {
            _deliveryFacade.DeliverOrder();
        }
    }
}
