using NcSafari.Animals;

namespace NcSafari.Utility
{
    internal class CompareWeight : IComparer<Animal>
    {
        private readonly bool _isAscendingOrder;

        public CompareWeight(bool isAscendingOrder)
        {
            _isAscendingOrder = isAscendingOrder;
        }

        public int Compare(Animal? x, Animal? y)
        {
            if (!_isAscendingOrder)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            else
            {
                return y.Weight.CompareTo(x.Weight);
            }
        }
    }
}
