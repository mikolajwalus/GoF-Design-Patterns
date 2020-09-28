using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Brigde
{
    public class RedCrystal : ICrystal
    {
        public string GetColour() => Colour;

        private string Colour = "red";
    }
}
