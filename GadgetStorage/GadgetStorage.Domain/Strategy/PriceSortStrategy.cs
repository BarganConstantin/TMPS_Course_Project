using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Strategy
{
    public class PriceSortStrategy : ISortStrategy
    {
        public List<AbstractGadget> Sort(List<AbstractGadget> gadgets)
        {
            gadgets.Sort((g1, g2) => g1.Price.CompareTo(g2.Price));
            return gadgets;
        }
    }
}
