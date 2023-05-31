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
    public class SmartWatchPrototype : ISmartWatchPrototype
    {
        public AbstractSmartWatch Clone(AbstractSmartWatch prototype)
        {
            AbstractSmartWatchBuilder builder = new SmartWatchBuilder();
            AbstractSmartWatch phone = builder
                .WithName<AbstractSmartWatchBuilder>(prototype.Name)
                .WithBrand<AbstractSmartWatchBuilder>(prototype.Brand)
                .WithCPUModel<AbstractSmartWatchBuilder>(prototype.CPUModel)
                .WithGPUModel<AbstractSmartWatchBuilder>(prototype.GPUModel)
                .WithDisplayTechnology<AbstractSmartWatchBuilder>(prototype.DisplayTechnology)
                .WithBatterySize<AbstractSmartWatchBuilder>(prototype.BatterySize)
                .WithHasCamera<AbstractSmartWatchBuilder>(prototype.HasCamera)
                .WithPrice<AbstractSmartWatchBuilder>(prototype.Price)
                .SetWithGPS(prototype.WithGPS)
                .Build();
            return phone;
        }
    }
}
