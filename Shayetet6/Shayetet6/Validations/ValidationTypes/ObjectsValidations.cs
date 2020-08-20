using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class ObjectsValidations
    {
        public bool IsValidString(string stringtocheck)
        {
            if (String.IsNullOrEmpty(stringtocheck))
                throw new NullReferenceException();
            return true;
        }
        public bool IsValidNumber(string stringtocheck)
        {
            int numberoutput;
            if (!(int.TryParse(stringtocheck, out numberoutput)) && !(IsValidString(stringtocheck)))
                throw new Exception("You must enter valid number");
            else
            {
                if (numberoutput < 0) throw new Exception("You must enter number greater or equal to 0");
                else
                    return true;
            }
        }
    }
}
