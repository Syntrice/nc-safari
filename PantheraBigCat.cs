using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class PantheraBigCat : Mammal
    {
        public PantheraBigCat(float weight, int speed) : base(weight, speed)
        {

        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
