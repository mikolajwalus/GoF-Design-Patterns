using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public class XWingFactory : FighterFactory
    {
        public override IFighter CreateFighter()
        {
            return new XWing();
        }
    }
}
