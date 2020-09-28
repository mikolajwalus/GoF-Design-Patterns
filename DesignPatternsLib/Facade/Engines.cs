using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class Engines
    {
        private bool Status { get; set; } = false;
        public void CheckStatus()
        {
            if (Status)
            {
                Console.WriteLine("Engines are on");
            }
            else
            {
                Console.WriteLine("Engines are off");
            }
        }
        public void StartEngines()
        {
            Status = true;
            CheckStatus();
        }
        public void StopEngines()
        {
            Status = false;
            CheckStatus();
        }
    }
}
