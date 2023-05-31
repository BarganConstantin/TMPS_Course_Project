using GadgetStorage.Domain.Facade.OrderFacade;

namespace GadgetStorage.Client.Command.Commands
{
    public class PrintOrdersCommand : ICommand
    {
        private readonly IOrderFacade _orderFacade;
        public PrintOrdersCommand(IOrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        public void Execute()
        {
            _orderFacade.PrintOrders();
        }
    }
}
