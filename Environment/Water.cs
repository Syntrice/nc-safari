using NcSafari.Animals;
using NcSafari.Animals.Ability;

namespace NcSafari.Environment
{
    internal class Water() : SafariEnvironment<ISwim>(maxSpeed: 2)
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                Console.WriteLine($"{animal.GetType().Name} is swimming");
            }
        }
    }
}
