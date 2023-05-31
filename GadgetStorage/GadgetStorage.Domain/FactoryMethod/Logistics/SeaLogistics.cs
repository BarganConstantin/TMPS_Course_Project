using GadgetStorage.Domain.FactoryMethod.Transport;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System.ComponentModel;

namespace GadgetStorage.Domain.FactoryMethod.Logistics
{
    public class SeaLogistics : AbstractLogistics
    {
        private readonly AbstractOrderStorage _orderStorage;
        public SeaLogistics(AbstractOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public override ITransport createTransport()
        {
            return new Ship(_orderStorage);
        }
    }
}
