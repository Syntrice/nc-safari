using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Mammal(float weight, int speed, Direction direction = Direction.Up) : Animal(weight, speed, direction)
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
