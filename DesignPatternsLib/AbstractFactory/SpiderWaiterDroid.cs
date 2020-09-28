using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class SpiderWaiterDroid : ISpiderDroid
    {
        public string Move()
        {
            return "Spider waiter droid moves to serve customers";
        }
    }
}
