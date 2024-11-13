using NcSafari.Animals;
using NcSafari.Animals.Ability;

namespace NcSafari.Environment
{
    internal class World
    {
        public List<Animal> Animals { get; }

        public World()
        {
            Animals = new List<Animal>
                {
                  new Tiger(70, 1, Direction.Down),
                  new Goose(5.2f, 2, Direction.Left),
                  new Bat(0.9f, 4, Direction.Right),
                  new Goose(4, 2, Direction.Up),
                  new Tiger(90, 3, Direction.Down),
                  new Penguin(15.8f, 1, Direction.Left)
                };

            Water water = new Water();
            HuntingGround ground = new HuntingGround();
            Sky sky = new Sky();

            water.AddAnimalInEnvironment(Animals[1]);
            water.AddAnimalInEnvironment(Animals[5]);

            ground.AddAnimalInEnvironment(Animals[0]);
            ground.AddAnimalInEnvironment(Animals[4]);

            sky.AddAnimalInEnvironment(Animals[2]);
            sky.AddAnimalInEnvironment(Animals[3]);

        }

        public void Tick()
        {
            Console.WriteLine("Tick");
            Console.WriteLine("{");
            foreach (Animal animal in Animals)
            {
                animal.Move();

                Console.Write($"Animal: {animal.GetType().Name}. ");
                Console.Write($"Position: {animal.Position}, ");
                Console.Write($"Direciton: {animal.Direction}, ");
                Console.Write($"Speed: {animal.Speed}, ");
                Console.WriteLine();
            }
            Console.WriteLine("}");
            Console.WriteLine();
        }
    }
}
