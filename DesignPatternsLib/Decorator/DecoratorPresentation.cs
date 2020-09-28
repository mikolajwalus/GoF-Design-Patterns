using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Decorator
{
    public class DecoratorPresentation
    {
        public void Main()
        {
            Sith vader = new Sith();
            SithMaster palpatine = new SithMaster(vader);

            palpatine.Suffocation();
            palpatine.ForcePush();
            palpatine.LightningAttack();
        }
    }
}
