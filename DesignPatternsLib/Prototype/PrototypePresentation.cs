using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Prototype
{
    public class PrototypePresentation
    {
        public void Main()
        {
            CloneTrooper first = new CloneTrooper()
            {
                IdNumber = 1,
                Weapon = new Blaster()
                {
                    Name = "V.10",
                    IdNumber = 1
                },

                Colour = "White",
                Helmet = "Ordinary",
                Generation = 3
            };

            CloneTrooper second = first.DeepCopy();
            Console.WriteLine($"First: {first.ToString()}");
            Console.WriteLine($"Second: {second.ToString()}");

            second.Helmet = "Sharpshooter helmet";

            Console.WriteLine($"First: {first.ToString()}");
            Console.WriteLine($"Second: {second.ToString()}");
        }
    }
}
