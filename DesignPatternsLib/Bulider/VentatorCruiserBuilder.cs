using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Bulider
{
    public class VentatorCruiserBuilder : ICruiserBuilder
    {

        public VentatorCruiser ventatorCruiser = new VentatorCruiser();

        public void AddFightersToHangar()
        {
            ventatorCruiser.Add("Fighters");
        }

        public void AddFrontCannonTurret()
        {
            ventatorCruiser.Add("Front Cannon");
        }

        public void AddHyperSpaceEngine()
        {
            ventatorCruiser.Add("Space Engine");
        }

        public void AddSideCannonTurret()
        {
            ventatorCruiser.Add("Side Cannon");
        }

        public VentatorCruiser GetCruiser()
        {
            return ventatorCruiser;
        }
    }
}
