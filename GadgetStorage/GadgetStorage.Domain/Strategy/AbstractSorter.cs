using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Strategy
{
    public abstract class AbstractSorter
    {
        protected ISortStrategy strategy;
        public abstract void SetStrategy(ISortStrategy strategy);
        public abstract void Sort(List<AbstractGadget> gadgets);
    }
}
