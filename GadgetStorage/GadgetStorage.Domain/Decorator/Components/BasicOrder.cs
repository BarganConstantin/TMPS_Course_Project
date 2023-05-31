using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator.Components
{
    public class BasicOrder : IOrder
    {
        public AbstractGadget _product;

        public BasicOrder(AbstractGadget product)
        {
            _product = product;
        }

        public double CalculateCost()
        {
            return Convert.ToDouble(_product.Price);
        }

        public string GetDescription()
        {
            return string.Format($"   Product Name: {_product.Name}\n   Product Price: {_product.Price}$\n");
        }
    }
}
