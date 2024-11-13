using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Bat : Mammal, IHunt, IFly
    {

        public Bat(float weight, int speed) : base(weight, speed)
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
