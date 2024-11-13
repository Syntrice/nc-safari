using NcSafari.Animals;

namespace NcSafari.Utility
{
    internal class WeightFormatter : IFormattable
    {

        private readonly Animal _userAnimal;
        public WeightFormatter(Animal userAnimal)
        {
            _userAnimal = userAnimal;
        }

        public string ToString(string? format, IFormatProvider? formatProvider) => format switch
        {
            "ounces" => $"This Tiger's weight is {Math.Round(_userAnimal.Weight * 35.274, 2).ToString(formatProvider)} ounces",
            _ => $"This Tiger's weight is {_userAnimal.Weight.ToString(formatProvider)} kilograms"
        };
    }
}
