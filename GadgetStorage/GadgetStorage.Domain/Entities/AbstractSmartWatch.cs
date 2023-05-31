using GadgetStorage.Domain.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public abstract class AbstractSmartWatch : AbstractGadget
    {
        public bool WithGPS { get; set; }

        protected AbstractSmartWatch(AbstractSmartWatchBuilder builder) : base(builder)
        {
            WithGPS = builder.WithGPS;
        }

        public abstract AbstractSmartWatch ShallowCopy();
        public abstract AbstractSmartWatch Clone();
    }
}
