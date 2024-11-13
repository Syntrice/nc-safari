using NcSafari.Animals;
using NcSafari.Animals.Ability;

namespace NcSafari.Environment
{
    internal class World
    {

        // a list of environments containing ITravel implementations
        public List<IEnvironment> Environments { get; }
        public List<Animal> Animals { get; }

        public World()
        {
            Animals = new List<Animal>
                {
                  new Tiger(70, 1),
                  new Goose(5.2f, 1),
                  new Bat(0.9f, 1),
                  new Goose(4, 1),
                  new Tiger(90, 1),
                  new Penguin(15.8f, 1)
                };

            Environments = new List<IEnvironment>();

            Water water = new Water();
            HuntingGround ground = new HuntingGround();
            Sky sky = new Sky();

            water.AddAnimalInEnvironment(Animals[1]);
            water.AddAnimalInEnvironment(Animals[5]);
            ground.AddAnimalInEnvironment(Animals[0]);
            ground.AddAnimalInEnvironment(Animals[4]);
            sky.AddAnimalInEnvironment(Animals[2]);
            sky.AddAnimalInEnvironment(Animals[3]);

            Environments.Add(water);
            Environments.Add(ground);
            Environments.Add(sky);
        }

        public void Tick()
        {

        }
    }
}
