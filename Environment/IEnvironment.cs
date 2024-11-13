using NcSafari.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari.Environment
{
    internal interface IEnvironment
    {
        public int MaxSpeed { get; set; }

        void MoveAnimals();

        void AddAnimalInEnvironment(Animal animal);

        void CheckAnimalsInEnvironment();
    }
}
