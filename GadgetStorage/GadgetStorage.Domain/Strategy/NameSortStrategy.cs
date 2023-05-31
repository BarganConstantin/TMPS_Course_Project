using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Strategy
{
    public class NameSortStrategy : ISortStrategy
    {
        public List<AbstractGadget> Sort(List<AbstractGadget> gadgets)
        {
            gadgets.Sort((g1, g2) => string.Compare(g1.Name, g2.Name));
            return gadgets;
        }
    }
}
