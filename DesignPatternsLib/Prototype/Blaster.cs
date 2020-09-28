using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Prototype
{
    [Serializable]
    public class Blaster
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, IdNumber: {IdNumber}";
        }
    }
}
