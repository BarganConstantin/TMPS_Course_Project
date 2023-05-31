using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Composite
{
    public abstract class ParcelComponent
    {
        public int Id;
        public abstract bool IsPack();
        public abstract void Add(ParcelComponent component);
        public abstract void Remove(ParcelComponent component);
        public abstract void Display(int space = 1);
        public abstract List<ParcelComponent> GetChildrens();
    }
}
