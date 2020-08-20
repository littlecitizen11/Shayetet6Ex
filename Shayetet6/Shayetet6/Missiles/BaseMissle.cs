using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public abstract class BaseMissile
    {
        public bool IsLaunched { get; set; }
        public string Name { get; set; }
        public IThechnique MissileTechnique { get; set; }
    }
}
