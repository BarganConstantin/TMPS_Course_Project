using GadgetStorage.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.PackFacade
{
    public interface IPackFacade
    {
        ParcelComponent CreateParcelForDelivery();
    }
}
