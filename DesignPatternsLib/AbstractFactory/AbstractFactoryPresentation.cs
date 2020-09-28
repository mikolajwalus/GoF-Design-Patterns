using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.AbstractFactory
{
    public class AbstractFactoryPresentation
    {
        public void Main()
        {
            IDroidFactory battleDroidFactory = new BattleDroidFactory();

            IWalkingDroid assultWalkingDroid = battleDroidFactory.CreateWalkingDroid();

            Console.WriteLine($"Walking battle droid: {assultWalkingDroid.Run()}");

            ISpiderDroid assultSpiderDroid = battleDroidFactory.CreateSpiderDroid();

            Console.WriteLine($"Spider battle droid: {assultSpiderDroid.Move()}");


            IDroidFactory serviceDroidFactory = new ServingDroidFactory();

            IWalkingDroid servingWalkingDroid = serviceDroidFactory.CreateWalkingDroid();

            Console.WriteLine($"Walking service droid: {servingWalkingDroid.Run()}");

            ISpiderDroid servingSpiderDroid = serviceDroidFactory.CreateSpiderDroid();

            Console.WriteLine($"Spider service droid: {servingSpiderDroid.Move()}");
        }
    }
}
