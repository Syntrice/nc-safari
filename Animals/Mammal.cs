namespace NcSafari.Animals
{
    internal class Mammal(float weight, int speed) : Animal(weight, speed)
    {
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
