using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public interface IThechnique
    {
        public string Name { get; set; }
        public  bool IsSucceeded(params object[] param);

    }
}
