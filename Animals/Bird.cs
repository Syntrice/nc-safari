using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Bird(float weight, int speed, Direction direction) : Animal(weight, speed, direction)
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
