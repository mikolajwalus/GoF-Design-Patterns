using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Decorator
{
    public class Sith
    {
        public void AttackWithLightsaber()
        {
            Console.WriteLine("Lightsaber attack");
        }
        public void ForcePush()
        {
            Console.WriteLine("Force Push");
        }
        public void Suffocation()
        {
            Console.WriteLine("Suffocation");
        }
    }
}
