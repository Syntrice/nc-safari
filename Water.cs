using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is Penguin)
                {
                    Console.WriteLine("Bat is swimming");
                }
                else if (animal is Goose)
                {
                    Console.WriteLine("Goose is swimming");
                }
                else
                {
                    Console.WriteLine("Something else is swimming");
                }
            }
        }
    }
}
