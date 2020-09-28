using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class BattleDroidFactory : IDroidFactory
    {
        public ISpiderDroid CreateSpiderDroid()
        {
            return new Droideka();
        }

        public IWalkingDroid CreateWalkingDroid()
        {
            return new BOneBattleDroid();
        }
    }
}
