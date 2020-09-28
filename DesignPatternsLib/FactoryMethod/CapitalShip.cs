using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public class CapitalShip
    {
        private readonly FighterFactory _factory;

        public CapitalShip( FighterFactory factory )
        {
            _factory = factory;
        }

        public string FighterAttack()
        {
            return _factory.CreateFighter().Fire();
        }
    }
}
