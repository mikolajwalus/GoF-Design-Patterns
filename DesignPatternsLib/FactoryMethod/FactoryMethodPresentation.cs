using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.FactoryMethod
{
    public class FactoryMethodPresentation
    {

        public void Main()
        {
            CapitalShip imperialCruiser = new CapitalShip(new TieFighterFactory());

            Console.WriteLine($"Imperial cruiser engages: {imperialCruiser.FighterAttack()}");

            CapitalShip rebelCruiser = new CapitalShip(new XWingFactory());

            Console.WriteLine($"Rebel cruiser attacks: {rebelCruiser.FighterAttack()}");
        }
    }
}
