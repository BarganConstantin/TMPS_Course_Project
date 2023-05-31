using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public abstract class AbstractTabletBuilder : AbstractGadgetBuilder
    {
        public bool HasStylusSupport;


        public AbstractTabletBuilder SetHasStylusSupport(bool HasStylusSupport)
        {
            this.HasStylusSupport = HasStylusSupport;
            return this;
        }

        public abstract AbstractTablet Build();
    }
}
