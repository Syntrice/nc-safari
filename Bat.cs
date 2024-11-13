using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Bat : Mammal, IHunt, IFly
    {

        public Bat(float weight) : base(weight)
        {

        }

        public void Hunt()
        {
            Console.WriteLine("Bat is hunting");
        }

        public void Fly()
        {
            Console.WriteLine("Bat is flying");
        }

    }
}
