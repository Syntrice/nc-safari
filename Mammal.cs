using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Mammal : Animal
    {
        public Mammal(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
