using GadgetStorage.Domain.Facade.ProductFacade;

namespace GadgetStorage.Client.Command.Commands
{
    public class PrintProductsCommand : ICommand
    {
        private readonly IProductFacade _productFacade;

        public PrintProductsCommand(IProductFacade productFacade)
        {
            _productFacade = productFacade;
        }

        public void Execute()
        {
            _productFacade.PrintProducts();
        }
    }
}
