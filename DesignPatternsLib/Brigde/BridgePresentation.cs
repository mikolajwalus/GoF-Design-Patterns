using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Brigde
{
    public class BridgePresentation
    {
        public void Main()
        {
            ICrystal greenCrystal = new GreenCrystal();
            ILightsaber yodasSword = new OneSideLightsaber(greenCrystal);

            Console.WriteLine("Yodas lightsaber:");
            yodasSword.UseLightsaber();

            ICrystal redCrystal = new RedCrystal();
            ILightsaber darthMaulsSword = new TwoSidedLightsaber(redCrystal);

            Console.WriteLine();
            Console.WriteLine("Darth Mauls lightsaber:");
            darthMaulsSword.UseLightsaber();

            ILightsaber fancySword = new TwoSidedLightsaber(greenCrystal);

            Console.WriteLine();
            Console.WriteLine("Fancy lightsaber:");
            fancySword.UseLightsaber();

        }
    }
}
