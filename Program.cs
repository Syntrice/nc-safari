using NcSafari.Animals;
using NcSafari.Environment;

namespace NcSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            
            for (int i = 0; i < 10; i++)
            {
                world.Tick();
            }

        }
    }

}
