namespace NcSafari.Animals
{
    internal class PantheraBigCat(float weight, int speed) : Mammal(weight, speed)
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine(GetType().Name + " roars!");
        }
    }
}
