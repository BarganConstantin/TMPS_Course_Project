using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GadgetStorage.Domain.Prototype
{
    public class PhonePrototype : IPhonePrototype
    {
        public AbstractPhone Clone(AbstractPhone prototype)
        {
            AbstractPhoneBuilder builder = new PhoneBuilder();
            AbstractPhone phone = builder
                .WithName<AbstractPhoneBuilder>(prototype.Name)
                .WithBrand<AbstractPhoneBuilder>(prototype.Brand)
                .WithCPUModel<AbstractPhoneBuilder>(prototype.CPUModel)
                .WithGPUModel<AbstractPhoneBuilder>(prototype.GPUModel)
                .WithDisplayTechnology<AbstractPhoneBuilder>(prototype.DisplayTechnology)
                .WithBatterySize<AbstractPhoneBuilder>(prototype.BatterySize)
                .WithHasCamera<AbstractPhoneBuilder>(prototype.HasCamera)
                .WithPrice<AbstractPhoneBuilder>(prototype.Price)
                .SetMaxCallTime(prototype.MaxCallTime)
                .Build();
            return phone;
        }
    }
}
