using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Bat(float weight, int speed) : Mammal(weight, speed), IHunt, IFly
    {
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
