using System.Numerics;

namespace NcSafari.Animals.Ability
{
    internal interface ITravel
    {

        public int Speed { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
