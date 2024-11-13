using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari
{
    internal class CompareWeight : IComparer<Animal>
    {
        private bool _isAscendingOrder;

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
