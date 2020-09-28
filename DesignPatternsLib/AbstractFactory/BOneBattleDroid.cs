using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class BOneBattleDroid : IWalkingDroid
    {
        public string Run()
        {
            return "BOneDroid runs";
        }
    }
}
