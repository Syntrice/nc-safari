﻿using System.Numerics;

namespace NcSafari.Animals.Ability
{
    internal interface ITravel
    {

        int Speed { get; set; }
        Vector2 Position { get; set; }
        Vector2 Direction { get; set; }

        void Move();
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
