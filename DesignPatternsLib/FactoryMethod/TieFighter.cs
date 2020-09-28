using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public class TieFighter : IFighter
    {
        public string Fire()
        {
            return "Tie fighter fires!";
        }
    }
}
