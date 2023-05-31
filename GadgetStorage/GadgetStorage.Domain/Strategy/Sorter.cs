using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Strategy
{
    public class Sorter : AbstractSorter
    {
        public Sorter(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public override void SetStrategy(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public override void Sort(List<AbstractGadget> _gadgets)
        {
            strategy.Sort(_gadgets);
        }
    }
}
