using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public abstract class AbstractGadgetBuilder
    {
        public string Name;
        public string Brand;
        public string CPUModel;
        public string GPUModel;
        public string DisplayTechnology;
        public string BatterySize;
        public string HasCamera;
        public string Price;
        public string Colour;

        public T WithName<T>(string name) where T : AbstractGadgetBuilder
        {
            Name = name;
            return (T)this;
        }

        public T WithBrand<T>(string brand) where T : AbstractGadgetBuilder
        {
            Brand = brand;
            return (T)this;
        }

        public T WithCPUModel<T>(string cpuModel) where T : AbstractGadgetBuilder
        {
            CPUModel = cpuModel;
            return (T)this;
        }

        public T WithGPUModel<T>(string gpuModel) where T : AbstractGadgetBuilder
        {
            GPUModel = gpuModel;
            return (T)this;
        }

        public T WithDisplayTechnology<T>(string displayTechnology) where T : AbstractGadgetBuilder
        {
            DisplayTechnology = displayTechnology;
            return (T)this;
        }

        public T WithBatterySize<T>(string batterySize) where T : AbstractGadgetBuilder
        {
            BatterySize = batterySize;
            return (T)this;
        }

        public T WithHasCamera<T>(string hasCamera) where T : AbstractGadgetBuilder
        {
            HasCamera = hasCamera;
            return (T)this;
        }

        public T WithPrice<T>(string price) where T : AbstractGadgetBuilder
        {
            Price = price;
            return (T)this;
        }

        public T WithColour<T>(string colour) where T : AbstractGadgetBuilder
        {
            Colour = colour;
            return (T)this;
        }
    }
}
