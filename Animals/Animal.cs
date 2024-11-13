using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal abstract class Animal(float weight, int speed = 3) : ITravel
    {
        public int Speed { get; set; } = speed;

        public float Weight { get; set; } = weight;

        public abstract void MakeSound();


        public int GetSpeed()
        {
            return Speed;
        }

    }
}
