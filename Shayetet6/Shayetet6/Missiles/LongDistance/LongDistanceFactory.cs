using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LongDistanceFactory : MissileFactory
    {
        public override BaseMissile Create() => new LongDistance();
    }
}
