using GadgetStorage.Domain.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public abstract class AbstractPhone : AbstractGadget
    {
        public int MaxCallTime { get; private set; }
        protected AbstractPhone(AbstractPhoneBuilder builder) : base (builder)
        { 
            MaxCallTime = builder.MaxCallTime;
        }

        public abstract AbstractPhone ShallowCopy();
        public abstract AbstractPhone Clone();
    }
}
