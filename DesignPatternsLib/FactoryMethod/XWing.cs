using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    class XWing : IFighter
    {
        public string Fire()
        {
            return "XWing Fires";
        }
    }
}
