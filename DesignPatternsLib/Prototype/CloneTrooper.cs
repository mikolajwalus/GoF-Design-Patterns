using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Prototype
{
    [Serializable]
    public class CloneTrooper
    {
        public int IdNumber { get; set; }
        public Blaster Weapon { get; set; }
        public string Colour { get; set; }
        public string Helmet { get; set; }
        public int Generation { get; set; }

        public override string ToString()
        {
            return $"IdNumber: {IdNumber}" +
                $"Weapon: {Weapon.ToString()}" +
                $"Colour: {Colour}" +
                $"Helmet: {Helmet}" +
                $"Generation: {Generation}";
        }
    }
}
