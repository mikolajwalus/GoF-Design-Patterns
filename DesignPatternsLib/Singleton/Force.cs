using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Singleton
{
    public class Force
    {
        private Force()
        {
            Console.WriteLine("Force has been created");
        }

        private static Lazy<Force> instance = new Lazy<Force>(() => new Force());

        public static Force GetInstance => instance.Value;
    }
}
