using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Decorator
{
    public interface IOrder
    {
        string GetDescription();
        double CalculateCost();
    }
}
