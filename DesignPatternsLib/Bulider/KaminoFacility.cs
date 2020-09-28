using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Bulider
{
    public class KaminoFacility
    {
        public ICruiserBuilder _builder;

        public void CreateFullCruiser()
        {
            _builder.AddFightersToHangar();
            _builder.AddFrontCannonTurret();
            _builder.AddHyperSpaceEngine();
            _builder.AddSideCannonTurret();
        }

        public void CreateCruiserSkeleron()
        {
            _builder.AddHyperSpaceEngine();
        }

    }
}
