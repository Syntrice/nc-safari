using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is Bat)
                {
                    Console.WriteLine("Bat is flying");
                }
                else if (animal is Goose)
                {
                    Console.WriteLine("Goose is flying");
                } else
                {
                    Console.WriteLine("Something else is flying");
                }
            }
        }
    }
}
