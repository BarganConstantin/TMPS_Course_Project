using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Prototype.Interfaces
{
    public interface IPhonePrototype
    {
        public AbstractPhone Clone(AbstractPhone prototype);
    }
}
