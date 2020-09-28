using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Decorator
{
    public class SithMaster
    {
        private readonly Sith _sith;

        public SithMaster(Sith sith)
        {
            _sith = sith;
        }
        public void AttackWithLightsaber()
        {
            _sith.AttackWithLightsaber();
        }
        public void ForcePush()
        {
            _sith.ForcePush();
        }
        public void Suffocation()
        {
            _sith.Suffocation();
        }
        public void LightningAttack()
        {
            Console.WriteLine("Lightning attack");
        }
    }
}
