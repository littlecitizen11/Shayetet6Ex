using Shayetet6.Thechnique;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Ballistic : BaseMissile
    {
        public Ballistic()
        {
            IsLaunched = false ;
            Name = GetType().Name;
            MissileTechnique = new Percents50Thechnique();
        }
    }
}
