using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Thechnique
{
    public class Percents100Thechnique : IThechnique
    {
        public string Name { get; set; }
        public int Probability { get; set; }
        public Percents100Thechnique()
        {
            Name = "100Percents";
            Probability = 100;
        }
        public bool IsSucceeded(params object[] param)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) <= Probability)
                return true;
            return false;
        }

    }
}
