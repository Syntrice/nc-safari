using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Bird : Animal
    {
        public Bird(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
