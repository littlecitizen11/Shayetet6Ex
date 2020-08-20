using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Thechnique
{
    public class ThechniqueHandler
    {
        public List<IThechnique> Thechniques { get; set; }
        public ThechniqueHandler()
        {
            Thechniques = new List<IThechnique>();
            Thechniques.Add(new Percents20Thechnique());
            Thechniques.Add(new Percents50Thechnique());
            Thechniques.Add(new Percents100Thechnique());
        }
    }
}
