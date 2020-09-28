using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Brigde
{
    public class OneSideLightsaber : ILightsaber
    {
        private readonly ICrystal _crystal;

        public OneSideLightsaber(ICrystal crystal)
        {
            _crystal = crystal;
        }
        public void UseLightsaber()
        {
            Console.WriteLine($"One Sided Lightsaber with {_crystal.GetColour()} force crystal");
        }
    }
}
