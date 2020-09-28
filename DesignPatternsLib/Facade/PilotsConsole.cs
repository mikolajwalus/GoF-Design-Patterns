using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Facade
{
    public class PilotsConsole
    {
        private Engines engines = new Engines();
        private HyperFuelSystem hyperFuelSystem = new HyperFuelSystem();
        private LifeSuportSystem lifeSuportSystem = new LifeSuportSystem();
        private NavigationSystem navigationSystem = new NavigationSystem();
        private Shields shields = new Shields();

        public void StartSystem()
        {
            engines.StartEngines();
            hyperFuelSystem.StartSystem();
            lifeSuportSystem.StartSystem();
        }
        public void StopSystem()
        {
            engines.StopEngines();
            hyperFuelSystem.StopSystem();
            lifeSuportSystem.StopSystem();
        }
        public void SetCoordinates(string coordinates)
        {
            navigationSystem.ResetCoordinates();
            navigationSystem.SetCordinates(coordinates);
            navigationSystem.CalculateTrace();
        }
        public void ActivateBattleMode()
        {
            shields.StartSystem();
        }
        public void DeactivateBattleMode()
        {
            shields.StopSystem();
        }
    }
}
