using GadgetStorage.Domain.FactoryMethod.Transport;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;

namespace GadgetStorage.Domain.FactoryMethod.Logistics
{
    public class RoadLogistics : AbstractLogistics
    {
        private readonly AbstractOrderStorage _orderStorage;
        public RoadLogistics(AbstractOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public override ITransport createTransport()
        {
            return new Truck(_orderStorage);
        }
    }
}
