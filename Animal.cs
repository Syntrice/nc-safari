using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal abstract class Animal : ITravel
    {
        public int Speed { get; set; } 

        public float Weight { get; set; }

        public Animal(float weight, int speed = 3)
        {
            Weight = weight;
            Speed = speed;
        }

        public abstract void MakeSound();


        public int GetSpeed()
        {
            return Speed;
        }

    }
}
