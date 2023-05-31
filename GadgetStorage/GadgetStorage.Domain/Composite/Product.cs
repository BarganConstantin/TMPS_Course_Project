using GadgetStorage.Domain.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Composite
{
    public class Product : ParcelComponent
    {
        private readonly IOrder _order;
        public Product(IOrder order)
        {
            _order = order;
            Id = order.GetHashCode();
        }

        public override void Add(ParcelComponent component)
        {
            Console.WriteLine("Cannot add to a product.");
        }

        public override void Display(int space = 1)
        {
            Console.WriteLine($"{new string(' ', space)}- order ID: {Id}");
        }

        public override List<ParcelComponent> GetChildrens()
        {
            Console.WriteLine("Product cannot have another components.");
            return new List<ParcelComponent>();
        }

        public override bool IsPack()
        {
            return false;
        }

        public override void Remove(ParcelComponent component)
        {
            Console.WriteLine("Cannot remove from a product.");
        }
    }
}
