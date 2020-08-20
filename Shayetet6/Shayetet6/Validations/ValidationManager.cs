using Shayetet6.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class ValidationManager
    {
        public MissileValidation missileValidation { get; set; }
        public UserValidation userValidation { get; set; }
        public ValidationManager()
        {
            missileValidation = new MissileValidation();
            userValidation = new UserValidation();
        }
    }
}
