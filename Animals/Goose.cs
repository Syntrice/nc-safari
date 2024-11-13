using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight, int speed) : base(weight, speed)
        {

        }

        public void Fly()
        {
            Console.WriteLine("Goose is flying");
        }

        public void Swim()
        {
            Console.WriteLine("Goose is swimming");
        }
    }
}
