using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.SingletonServices.ProductsStorage
{
    public abstract class AbstractProductStorage
    {
        protected static List<AbstractGadget> _gadgets;
        private static readonly object padlock = new object();

        static AbstractProductStorage() { }

        protected static List<AbstractGadget> GetInstance()
        {
            if (_gadgets == null)
            {
                lock (padlock)
                {
                    if (_gadgets == null)
                    {
                        _gadgets = new List<AbstractGadget>();
                    }
                }
            }
            return _gadgets;
        }

        public abstract List<AbstractGadget> GetProductsList();
        public abstract void AddProduct(AbstractGadget gadget);
        public abstract void RemoveProduct(AbstractGadget gadget);
        public abstract AbstractGadget GetProductById(int id);
        public abstract IProductIterator GetIterator();
    }
}
