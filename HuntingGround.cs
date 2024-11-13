using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class HuntingGround : SafariEnvironment<IHunt>
    {
        public HuntingGround() : base(maxSpeed: 5)
        {
        }
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                Type[] implementedInterfaces = animal.GetType().GetInterfaces();

                if (implementedInterfaces.Contains(typeof(IFly)))
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting in the skies above the hunting ground");
                }
                else if (implementedInterfaces.Contains(typeof(ISwim)))
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting in the waters of the hunting ground");
                }
                else
                {
                    Console.WriteLine($"{animal.GetType().Name} is hunting on land in the hunting ground");
                }

            }
        }
    }
}
