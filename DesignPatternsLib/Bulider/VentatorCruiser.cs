using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Bulider
{
    public class VentatorCruiser
    {
        private List<string> _features = new List<string>();

        public void Add(string feature)
        {
            _features.Add(feature);
        }

        public void ShowFeatures()
        {
            Console.WriteLine("Features");

            foreach (string feature in _features)
            {
                Console.WriteLine(feature);
            }
        }
    }
}
