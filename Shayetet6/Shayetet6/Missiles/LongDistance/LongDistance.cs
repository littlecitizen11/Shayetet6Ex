using Shayetet6.Thechnique;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LongDistance : BaseMissile
    {

        public LongDistance()
        {
            IsLaunched = false;
            Name = GetType().Name;
            MissileTechnique = new LongDistanceThechnique();
        }

    }
}
