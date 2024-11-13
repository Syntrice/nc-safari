using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari.Animals
{
    internal class Bird : Animal
    {
        public Bird(float weight, int speed) : base(weight, speed)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
