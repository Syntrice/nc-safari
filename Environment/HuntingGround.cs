using NcSafari.Animals;
using NcSafari.Animals.Ability;

namespace NcSafari.Environment
{
    internal class HuntingGround() : SafariEnvironment<IHunt>(3)
    {
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
