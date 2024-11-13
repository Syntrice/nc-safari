using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal abstract class SafariEnvironment<IEnvironment>
    {
        protected List<Animal> animalsInEnvironment = new List<Animal>();

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            this.animalsInEnvironment.Add(animal);
        }
    }
}
