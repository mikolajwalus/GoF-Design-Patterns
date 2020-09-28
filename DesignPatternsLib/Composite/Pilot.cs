using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Composite
{
    public class Pilot
    {
        private readonly IHyperdrive _hyperdrive;

        public Pilot(IHyperdrive hyperdrive)
        {
            _hyperdrive = hyperdrive;
        }

        public void StartFighter()
        {
            Console.WriteLine(_hyperdrive.StartHyperdrive());
        }
    }
}
