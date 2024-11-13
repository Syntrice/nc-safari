using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal abstract class Animal
    {
        public float Weight { get; set; }

        public Animal(float weight)
        {
            Weight = weight;
        }

        public abstract void MakeSound();
    }
}
