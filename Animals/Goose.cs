using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Goose(float weight, int speed = 3, Direction direction = Direction.Up) : Bird(weight, speed, direction), IFly, ISwim
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
