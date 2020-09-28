using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class NavigationSystem
    {
        private string Coordinates { get; set; } = null;
        private string Trace { get; set; } = null;
        public void ResetCoordinates()
        {
            Coordinates = null;
        }
        public void DeleteTrace()
        {
            Trace = null;
        }
        public void SetCordinates(string coordinates)
        {
            Coordinates = coordinates;
        }
        public void CalculateTrace()
        {
            Trace = Coordinates;
        }
    }
}
