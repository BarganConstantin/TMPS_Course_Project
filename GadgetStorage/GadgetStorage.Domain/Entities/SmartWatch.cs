using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public class SmartWatch : AbstractSmartWatch
    {
        public SmartWatch(AbstractSmartWatchBuilder builder) : base(builder) 
        { 
        }
        public override AbstractSmartWatch ShallowCopy()
        {
            return (AbstractSmartWatch) MemberwiseClone();
        }

        public override AbstractSmartWatch Clone()
        {
            
            return new SmartWatchPrototype().Clone(this);
        }
    }
}
