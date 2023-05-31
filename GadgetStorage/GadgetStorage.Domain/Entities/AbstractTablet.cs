using GadgetStorage.Domain.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public abstract class AbstractTablet : AbstractGadget
    {
        public bool HasStylusSupport { get; set; }

        protected AbstractTablet(AbstractTabletBuilder builder) : base(builder)
        {
            HasStylusSupport = builder.HasStylusSupport;
        }

        public abstract AbstractTablet ShallowCopy();
        public abstract AbstractTablet Clone();
    }
}
