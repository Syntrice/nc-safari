using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Tiger(float weight, int speed = 3, Direction direction = Direction.Up) : Mammal(weight, speed, direction), IHunt
    {
        public void Hunt()
        {
            Console.WriteLine("Tiger is hunting!");
        }
    }
}
