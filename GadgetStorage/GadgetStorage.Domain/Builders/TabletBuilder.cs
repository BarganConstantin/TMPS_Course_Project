using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public class TabletBuilder : AbstractTabletBuilder
    {
        public override AbstractTablet Build()
        {
            return new Tablet(this);
        }
    }
}
