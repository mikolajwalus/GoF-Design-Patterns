using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class LifeSuportSystem
    {
        private bool Status { get; set; } = false;
        public void CheckStatus()
        {
            if (Status)
            {
                Console.WriteLine("Life Support System is now working");
            }
            else
            {
                Console.WriteLine("Life Support System is off");
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
