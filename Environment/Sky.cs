using NcSafari.Animals;
using NcSafari.Animals.Ability;

namespace NcSafari.Environment
{
    internal class Sky() : SafariEnvironment<IFly>(maxSpeed: 5)
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                Console.WriteLine($"{animal.GetType().Name} is flying");
            }
        }
    }
}
