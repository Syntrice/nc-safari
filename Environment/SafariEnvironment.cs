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
            if (animal.Speed > MaxSpeed)
            {
                Console.WriteLine("Animal is moving faster than this envirnoment allows!");
                return;
            }

            animalsInEnvironment.Add(animal);
            
        }
    }
}
