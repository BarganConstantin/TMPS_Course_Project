using GadgetStorage.Domain.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Entities
{
    public abstract class AbstractGadget
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public string CPUModel { get; private set; }
        public string GPUModel { get; private set; }
        public string DisplayTechnology { get; private set; }
        public string BatterySize { get; private set; }
        public string HasCamera { get; private set; }
        public string Price { get; private set; }
        public string Colour { get; private set; }

        protected AbstractGadget(AbstractGadgetBuilder builder) 
        {
            Id = 0;
            Name = builder.Name;
            Brand = builder.Brand;
            CPUModel = builder.CPUModel;
            GPUModel = builder.GPUModel;
            DisplayTechnology = builder.DisplayTechnology;
            BatterySize = builder.BatterySize;
            HasCamera = builder.HasCamera;
            Price = builder.Price;
            Colour = builder.Colour;
        }
    }
}
