using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Composite
{
    public class CompositePresentation
    {
        public void Main()
        {
            var firstBottomHyperdirve = new SingleHyperdive("Engine One");
            var secondBottomHyperdirve = new SingleHyperdive("Engine Two");
            var thirdBottomHyperdirve = new SingleHyperdive("Engine Three");
            var fourthBottomHyperdirve = new SingleHyperdive("Engine Four");

            var bottomHyperdrive = new HyperdiveAssembly("Back Engine");

            bottomHyperdrive.AddNewEngine(firstBottomHyperdirve);
            bottomHyperdrive.AddNewEngine(secondBottomHyperdirve);
            bottomHyperdrive.AddNewEngine(thirdBottomHyperdirve);
            bottomHyperdrive.AddNewEngine(fourthBottomHyperdirve);

            var firstFrontHyperdrive = new SingleHyperdive("Engine Three");
            var secondFrontHyperdrive = new SingleHyperdive("Engine Four");

            var frontHyperdrive = new HyperdiveAssembly("Back Engine");

            frontHyperdrive.AddNewEngine(firstFrontHyperdrive);
            frontHyperdrive.AddNewEngine(secondFrontHyperdrive);

            var hyperdrive = new HyperdiveAssembly("Main hyperdrive");

            hyperdrive.AddNewEngine(frontHyperdrive);
            hyperdrive.AddNewEngine(bottomHyperdrive);

            Pilot pilot = new Pilot(hyperdrive);

            pilot.StartFighter();
        }
      
    }
}
