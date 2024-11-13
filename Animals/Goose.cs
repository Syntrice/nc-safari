using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Goose(float weight, int speed) : Bird(weight, speed), IFly, ISwim
    {
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
