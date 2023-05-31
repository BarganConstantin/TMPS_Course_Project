using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Strategy
{
    public interface ISortStrategy
    {
        List<AbstractGadget> Sort(List<AbstractGadget> gadgets);
    }
}
