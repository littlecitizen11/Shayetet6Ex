﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class TorpedoFactory:MissileFactory
    {
        public override BaseMissile Create() => new Torpedo();
    }
}
