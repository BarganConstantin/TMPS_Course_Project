using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.ProductFacade
{
    public interface IProductFacade
    {
        void RegisterProduct();
        void RemoveProduct(AbstractGadget product);
        void PrintProducts();
    }
}
