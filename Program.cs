using NcSafari.Animals;
using NcSafari.Environment;

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

            Water water = new Water();

            Console.WriteLine(betty.GetSpeed());
            water.AddAnimalInEnvironment(betty);

            water.CheckAnimalsInEnvironment();
            Console.WriteLine(betty.GetSpeed());

        }
    }

}
