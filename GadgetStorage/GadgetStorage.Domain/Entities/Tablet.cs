using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public class Tablet : AbstractTablet
    {
        public Tablet(AbstractTabletBuilder builder) : base(builder) 
        { 
        }

        public override AbstractTablet ShallowCopy()
        {
            return (AbstractTablet)MemberwiseClone();
        }

        public override AbstractTablet Clone()
        {
            return new TabletPrototype().Clone(this);
        }
    }
}
