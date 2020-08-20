using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class BallisticFactory : MissileFactory
    {
        public override BaseMissile Create() => new Ballistic();
    }
}
