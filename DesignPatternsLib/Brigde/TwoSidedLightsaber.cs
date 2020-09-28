using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Brigde
{
    public class TwoSidedLightsaber : ILightsaber
    {
        private readonly ICrystal _crystal;

        public TwoSidedLightsaber(ICrystal crystal)
        {
            _crystal = crystal;
        }
        public void UseLightsaber()
        {
            Console.WriteLine($"Two Sided Lightsaber with {_crystal.GetColour()} force crystal");
        }
    }
}
