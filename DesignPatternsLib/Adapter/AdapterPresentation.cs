using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Adapter
{
    public class AdapterPresentation
    {
        public void Main()
        {
            Palpatine emperor = new Palpatine();
            Republic republic = new Republic();
            CloneArmy cloneArmy = new CloneArmy(republic);

            emperor.empire = cloneArmy;
            emperor.empire.DoWhatEmperorWant();
        }
    }
}
