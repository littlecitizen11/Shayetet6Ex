using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Shayetet6
{
    public class MissileValidation
    {
        public Missles Missiles { get; set; }
        public MissileValidation()
        {
        }
        public void IsMissileExists(string missile)
        {
            
            if (!Enum.IsDefined(typeof(Missles), missile))
                throw new Exception("There is no such a missile");
        }

    }
}
