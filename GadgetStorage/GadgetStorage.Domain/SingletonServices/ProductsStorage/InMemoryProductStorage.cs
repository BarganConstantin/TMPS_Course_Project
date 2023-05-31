using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.Iterator;
using GadgetStorage.Domain.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.SingletonServices.ProductsStorage
{
    public class InMemoryProductStorage : AbstractProductStorage
    {
        private ISortStrategy _sortStrategy;
        public override List<AbstractGadget> GetProductsList()
        {
            return GetInstance();
        }

        public override void AddProduct(AbstractGadget gadget)
        {
            List<AbstractGadget> gadgets = GetInstance();
            gadget.Id = gadgets.Count;
            gadgets.Add(gadget);
        }

        public override void RemoveProduct(AbstractGadget gadget)
        {
            List<AbstractGadget> gadgets = GetInstance();
            gadgets.Remove(gadget);
        }

        public override AbstractGadget GetProductById(int id)
        {
            List<AbstractGadget> gadgets = GetInstance();
            return gadgets.FirstOrDefault(g => g.Id == id);
        }

        public void SetSortStrategy(ISortStrategy strategy)
        {
            _sortStrategy = strategy;
        }

        public void SortProducts()
        {
            _gadgets = _sortStrategy.Sort(_gadgets);
        }

        private class ProductIterator : IProductIterator
        {
            private readonly List<AbstractGadget> _gadgets;
            private int _index;

            public ProductIterator(List<AbstractGadget> gadgets)
            {
                _gadgets = gadgets;
                _index = 0;
            }

            public bool HasNext()
            {
                return _index < _gadgets.Count;
            }

            public AbstractGadget Next()
            {
                AbstractGadget gadget = _gadgets[_index];
                _index++;
                return gadget;
            }
        }

        public override IProductIterator GetIterator()
        {
            return new ProductIterator(GetInstance());
        }
    }
}
