using NcSafari.Animals.Ability;
using System.Numerics;

namespace NcSafari.Animals
{
    internal abstract class Animal(float weight, int speed = 3) : ITravel
    {
        public int Speed { get; set; } = speed;

        public Vector2 Position { get; set; } = new Vector2();

        public Direction Direction { get; set; } = Direction.Up;

        public float Weight { get; set; } = weight;

        public abstract void MakeSound();

        public void Move()
        {
            switch (Direction)
            {
                case Direction.Up:
                    Position = new Vector2(Position.X, Position.Y + Speed);
                    break;
                case Direction.Down:
                    Position = new Vector2(Position.X, Position.Y - Speed);
                    break ;
                case Direction.Left:
                    Position = new Vector2(Position.X - Speed, Position.Y);
                    break;
                case Direction.Right:
                    Position = new Vector2(Position.X - Speed, Position.Y);
                    break;

            }
        }
    }
}
