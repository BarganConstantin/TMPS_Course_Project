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
    public class TabletPrototype : ITabletPrototype
    {
        public AbstractTablet Clone(AbstractTablet prototype)
        {
            AbstractTabletBuilder builder = new TabletBuilder();
            AbstractTablet phone = builder
                .WithName<AbstractTabletBuilder>(prototype.Name)
                .WithBrand<AbstractTabletBuilder>(prototype.Brand)
                .WithCPUModel<AbstractTabletBuilder>(prototype.CPUModel)
                .WithGPUModel<AbstractTabletBuilder>(prototype.GPUModel)
                .WithDisplayTechnology<AbstractTabletBuilder>(prototype.DisplayTechnology)
                .WithBatterySize<AbstractTabletBuilder>(prototype.BatterySize)
                .WithHasCamera<AbstractTabletBuilder>(prototype.HasCamera)
                .WithPrice<AbstractTabletBuilder>(prototype.Price)
                .SetHasStylusSupport(prototype.HasStylusSupport)
                .Build();
            return phone;
        }
    }
}
