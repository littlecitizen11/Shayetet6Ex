using Shayetet6.Thechnique;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Cruise : BaseMissile
    {
        public Cruise()
        {
            IsLaunched = false;
            Name = GetType().Name;
            MissileTechnique = new Percents20Thechnique();

        }

    }
}
