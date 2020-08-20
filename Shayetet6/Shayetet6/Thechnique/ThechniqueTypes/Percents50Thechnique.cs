using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Thechnique
{
    public class Percents50Thechnique : IThechnique
    {
        public string Name { get; set; }
        public int Probability { get; set; }
        public Percents50Thechnique()
        {
            Name = "50Percents";
            Probability = 50;
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
