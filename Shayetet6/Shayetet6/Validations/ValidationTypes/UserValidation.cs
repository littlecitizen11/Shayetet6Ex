using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Shayetet6.Menu
{
    public class UserValidation
    {
        public ObjectsValidations objectsValidations { get; set; }
        public UserValidation()
        {
            objectsValidations = new ObjectsValidations();
        }
        public int IntInput()
        {
            string intinput = Console.ReadLine();
            while (!(objectsValidations.IsValidNumber(intinput)))
                intinput = Console.ReadLine();
            return int.Parse(intinput);

        }
        public string StringInput()
        {
            string stringinput = Console.ReadLine();
            while (!(objectsValidations.IsValidString(stringinput)))
                stringinput = Console.ReadLine();
            return stringinput;

        }


    }
}
