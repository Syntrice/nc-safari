using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class PantheraBigCat(float weight, int speed = 3, Direction direction = Direction.Up) : Mammal(weight, speed, direction), IHunt
    {
        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(GetType().Name + " roars!");
        }
    }
}
