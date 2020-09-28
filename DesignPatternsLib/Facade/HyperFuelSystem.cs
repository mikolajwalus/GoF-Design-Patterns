using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class HyperFuelSystem
    {
        private bool Status { get; set; } = false;
        public void CheckStatus()
        {
            if (Status)
            {
                Console.WriteLine("Hyper Fuel System is supplying fueal to engines");
            }
            else
            {
                Console.WriteLine("Hyper Fuel System is off");
            }
        }
        public void StartSystem()
        {
            Status = true;
            CheckStatus();
        }
        public void StopSystem()
        {
            Status = false;
            CheckStatus();
        }
    }
}
