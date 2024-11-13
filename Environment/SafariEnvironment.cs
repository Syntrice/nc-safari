using NcSafari.Animals;


namespace NcSafari.Environment
{
    internal abstract class SafariEnvironment<IEnvironment>(int maxSpeed)
    {
        public int MaxSpeed { get; set; } = maxSpeed;

        protected List<Animal> animalsInEnvironment = []; // shorthand

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            animalsInEnvironment.Add(animal);
            if (animal.Speed > MaxSpeed)
            {
                animal.Speed = MaxSpeed;
            }
        }



    }
}
