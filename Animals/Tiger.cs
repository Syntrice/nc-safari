using NcSafari.Animals.Ability;

namespace NcSafari.Animals
{
    internal class Tiger(float weight, int speed) : PantheraBigCat(weight, speed), IHunt
    {
        public void Hunt()
        {
            Console.WriteLine("Tiger is hunting!");
        }
    }
}
