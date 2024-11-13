using NcSafari.Animals;


namespace NcSafari.Environment
{
    internal abstract class SafariEnvironment<IAbility>(int maxSpeed) : IEnvironment
    {
        public int MaxSpeed { get; set; } = maxSpeed;

        protected List<Animal> animalsInEnvironment = []; // shorthand

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            // if animal does not implement the correct environment ability
            if (animal is not IAbility)
            {
                Console.WriteLine("Animal cannot survive in this environment!");
                return;
            }

            if (animal.Speed > MaxSpeed)
            {
                Console.WriteLine("Animal has faster speed than this envirnoment allows!");
                return;
            }

            animalsInEnvironment.Add(animal);
            
        }
    }
}
