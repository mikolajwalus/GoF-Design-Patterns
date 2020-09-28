using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public abstract class FighterFactory
    {
        public abstract IFighter CreateFighter();
        public string FighterFire()
        {
            var fighter = CreateFighter();

            var result = fighter.Fire();

            return result;
        }
    }
}
