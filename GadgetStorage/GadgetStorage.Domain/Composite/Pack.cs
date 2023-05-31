using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Composite
{
    public class Pack : ParcelComponent
    {
        private List<ParcelComponent> _children = new List<ParcelComponent>();

        public Pack(int packId)
        {
            Id = packId;
        }

        public override void Add(ParcelComponent component)
        {
            _children.Add(component);
        }

        public override void Display(int space = 1)
        {
            Console.WriteLine();
            Console.WriteLine(new string(' ', space) + "pack" + $" (ID: {Id})");
            Console.WriteLine(new string(' ', space) + "[");

            if (_children.Count > 0)
            {
                foreach (ParcelComponent component in _children)
                {
                    component.Display(space + 2);
                }
            }
            else
            {
                Console.WriteLine(new string(' ', space + 2) + "- empty");
            }

            Console.WriteLine(new string(' ', space) + "]");
        }

        public override void Remove(ParcelComponent component)
        {
            _children.Remove(component);
        }

        public override bool IsPack()
        {
            return true;
        }

        public override List<ParcelComponent> GetChildrens()
        {
            return _children;
        }
    }
}
