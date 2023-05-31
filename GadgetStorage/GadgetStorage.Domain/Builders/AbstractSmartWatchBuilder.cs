using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public abstract class AbstractSmartWatchBuilder : AbstractGadgetBuilder
    {
        public bool WithGPS;

        public AbstractSmartWatchBuilder SetWithGPS(bool WithGPS)
        {
            this.WithGPS = WithGPS;
            return this;
        }

        public abstract AbstractSmartWatch Build();
    }
}
