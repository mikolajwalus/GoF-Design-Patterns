using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class ServingDroidFactory : IDroidFactory
    {
        public ISpiderDroid CreateSpiderDroid()
        {
            return new SpiderWaiterDroid();
        }

        public IWalkingDroid CreateWalkingDroid()
        {
            return new CThreePODroid();
        }
    }
}
