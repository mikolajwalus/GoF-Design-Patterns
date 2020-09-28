using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class Shields
    {
        private bool Status { get; set; } = false;
        public void CheckStatus()
        {
            if (Status)
            {
                Console.WriteLine("All shields online");
            }
            else
            {
                Console.WriteLine("Shields are disabled");
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
