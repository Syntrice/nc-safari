using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weight, int speed) : base(weight, speed)
        {

        }

        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting!");
        }
        
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }


        public override void MakeSound()
        {
            Console.WriteLine("Squeek squeek!");
        }
    }
}
