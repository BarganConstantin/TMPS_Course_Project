using GadgetStorage.Domain.FactoryMethod.Transport;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;

namespace GadgetStorage.Domain.FactoryMethod.Logistics
{
    public class AirLogistics : AbstractLogistics
    {
        private readonly AbstractOrderStorage _orderStorage;
        public AirLogistics(AbstractOrderStorage orderStorage)
        {
            _orderStorage = orderStorage;
        }

        public override ITransport createTransport()
        {
            return new Plane(_orderStorage);
        }
    }
}
