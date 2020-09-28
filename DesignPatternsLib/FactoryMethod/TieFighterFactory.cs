using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public class TieFighterFactory : FighterFactory
    {
        public override IFighter CreateFighter()
        {
            return new TieFighter();
        }
    }
}
