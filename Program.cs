using NcSafari.Animals;
using NcSafari.Environment;

namespace NcSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Tick();

        }
    }

}
