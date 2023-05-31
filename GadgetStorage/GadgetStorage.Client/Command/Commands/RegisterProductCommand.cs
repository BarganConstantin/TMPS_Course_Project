using GadgetStorage.Domain.Facade.ProductFacade;

namespace GadgetStorage.Client.Command.Commands
{
    public class RegisterProductCommand : ICommand
    {
        private readonly IProductFacade _productFacade;
        public RegisterProductCommand(IProductFacade productFacade)
        {
            _productFacade = productFacade;
        }

        public void Execute()
        {
            _productFacade.RegisterProduct();
        }
    }
}
