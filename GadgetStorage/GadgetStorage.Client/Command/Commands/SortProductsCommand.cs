using GadgetStorage.Domain.Adapter;
using GadgetStorage.Domain.Facade.ProductFacade;
using GadgetStorage.Domain.Strategy;
using System;

namespace GadgetStorage.Client.Command.Commands
{
    public class SortProductsCommand : ICommand
    {
        private readonly IProductFacade _productFacade;

        public SortProductsCommand(IProductFacade productFacade) 
        {
            _productFacade = productFacade;
        }

        public void Execute()
        {
            _productFacade.SortProducts();
        }
    }
}
