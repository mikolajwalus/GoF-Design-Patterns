using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class FacadePresentation
    {
        public void Main()
        {
            PilotsConsole console = new PilotsConsole();

            console.StartSystem();
            console.SetCoordinates("Kamino");

            console.ActivateBattleMode();
            console.DeactivateBattleMode();

            console.StopSystem();
        }
    }
}
