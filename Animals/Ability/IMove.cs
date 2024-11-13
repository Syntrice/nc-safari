using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcSafari.Animals.Ability
{
    [Obsolete("Use IHunt, ISwim, or IFly instead", true)]
    internal interface IMove
    {
        void Move();
    }
}
