using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class CruiseFactory : MissileFactory
    {
        public override BaseMissile Create() => new Cruise();
    }
}
