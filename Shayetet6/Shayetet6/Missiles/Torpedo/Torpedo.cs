using Shayetet6.Thechnique;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Torpedo : BaseMissile
    {
        public Torpedo()
        {
            IsLaunched = false;
            Name = GetType().Name;
            MissileTechnique = new Percents100Thechnique();

        }
    }
}
