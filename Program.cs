using System.Globalization;

namespace NcSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger fluffy = new Tiger(80, 10);
            Penguin penny = new Penguin(20.4f, 3);
            Goose jeff = new Goose(3, 3);
            Bat betty = new Bat(0.7f, 6);

            //Sky sky = new Sky();
            //sky.AddAnimalInEnvironment(betty);
            //sky.AddAnimalInEnvironment(jeff);

            //sky.CheckAnimalsInEnvironment();

            Water water = new Water();

            Console.WriteLine(betty.GetSpeed());
            water.AddAnimalInEnvironment(betty);

            water.CheckAnimalsInEnvironment();
            Console.WriteLine(betty.GetSpeed());


            //HuntingGround hunting = new HuntingGround();
            //hunting.AddAnimalInEnvironment(betty);
            //hunting.AddAnimalInEnvironment(fluffy);
            //hunting.AddAnimalInEnvironment(penny);

            //hunting.CheckAnimalsInEnvironment();

            //List<Animal> animalsToSee = new List<Animal>
            //{
            //  new Tiger(70),
            //  new Goose(5.2f),
            //  new Bat(0.9f),
            //  new Goose(4),
            //  new Tiger(90),
            //  new Penguin(15.8f)
            //};

            //animalsToSee.Sort(new CompareWeight(false));

            //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

            //Tiger pumpkin = new Tiger(100.4f); 

            //WeightFormatter pumpkinWeightFormatter = new WeightFormatter(pumpkin);
            //Console.WriteLine(pumpkinWeightFormatter.ToString("ounces", new CultureInfo("de-DE"))); 

        }
    }

}
