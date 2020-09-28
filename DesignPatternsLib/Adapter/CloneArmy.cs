using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Adapter
{
    public class CloneArmy : IEmpire
    {
        private readonly Republic _republic;

        public CloneArmy(Republic republic)
        {
            _republic = republic;
        }
        public void DoWhatEmperorWant()
        {
            _republic.RuleRepublic();
        }
    }
}
