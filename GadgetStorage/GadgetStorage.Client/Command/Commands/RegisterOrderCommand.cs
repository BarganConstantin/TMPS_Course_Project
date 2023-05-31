using GadgetStorage.Domain.Facade.OrderFacade;

namespace GadgetStorage.Client.Command.Commands
{
    public class RegisterOrderCommand : ICommand
    {
        private readonly IOrderFacade _orderFacade;
        public RegisterOrderCommand(IOrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        public void Execute()
        {
            _orderFacade.RegisterOrder();
            _orderFacade.PrintOrders();
        }
    }
}
