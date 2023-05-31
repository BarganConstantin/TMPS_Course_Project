using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public class Phone : AbstractPhone
    {
        public Phone(AbstractPhoneBuilder builder) : base(builder) 
        { 
        }

        public override AbstractPhone ShallowCopy()
        {
            return (AbstractPhone) MemberwiseClone();
        }

        public override AbstractPhone Clone()
        {
            return new PhonePrototype().Clone(this);
        }
    }
}
