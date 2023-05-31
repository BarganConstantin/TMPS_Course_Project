using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public class SmartWatchBuilder : AbstractSmartWatchBuilder
    {
        public override AbstractSmartWatch Build()
        {
            return new SmartWatch(this);
        }
    }
}
