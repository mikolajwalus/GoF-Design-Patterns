using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class CThreePODroid : IWalkingDroid
    {
        public string Run()
        {
            return "C3PO Runs!";
        }
    }
}
