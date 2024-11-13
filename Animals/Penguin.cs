using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Penguin(float weight, int speed = 3, Direction direction = Direction.Up) : Bird(weight, speed, direction), IHunt, ISwim
    {
        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }


        public override void MakeSound()
        {
            Console.WriteLine("Squeek squeek!");
        }
    }
}
