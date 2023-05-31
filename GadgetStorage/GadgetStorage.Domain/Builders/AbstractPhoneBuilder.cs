using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public abstract class AbstractPhoneBuilder : AbstractGadgetBuilder
    {
        public int MaxCallTime;

        public AbstractPhoneBuilder SetMaxCallTime(int MaxCallTime)
        {
            this.MaxCallTime = MaxCallTime;
            return this;
        }

        public abstract AbstractPhone Build();
    }
}
