using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shayetet6.Thechnique
{
    public class LongDistanceThechnique : IThechnique
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public LongDistanceThechnique()
        {
            Name = "LongDistance";
            Distance = 1500;
        }

        public bool IsSucceeded(params object[] param)
        {
            Random rnd = new Random();
            int probability = ((int)param.GetValue(0)/Distance) * 100;
            if (rnd.Next(0, 100) <= probability)
                return true;
            return false;
        }
    }
}
