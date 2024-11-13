using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal abstract class SafariEnvironment<IEnvironment>
    {
        public int MaxSpeed { get; set; } 

        protected List<Animal> animalsInEnvironment = new List<Animal>();

        public SafariEnvironment(int maxSpeed) {
            MaxSpeed = maxSpeed; 
        }

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            this.animalsInEnvironment.Add(animal);
            if (animal.Speed > MaxSpeed)
            {
                animal.Speed = MaxSpeed;
            }
        }

        

    }
}
