using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class Droideka : ISpiderDroid
    {
        public string Move()
        {
            return "Droideka moves forward";
        }
    }
}
