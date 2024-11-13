using NcSafari.Animals.Ability;
using System.Numerics;

namespace NcSafari.Animals
{
    internal abstract class Animal(float weight, int speed = 3) : ITravel
    {
        public int Speed { get; set; } = speed;

        public Vector2 Position { get; set; } = Vector2.Zero;

        public Vector2 Direction { get; set; } = Vector2.Zero;

        public float Weight { get; set; } = weight;

        public abstract void MakeSound();
    }
}
