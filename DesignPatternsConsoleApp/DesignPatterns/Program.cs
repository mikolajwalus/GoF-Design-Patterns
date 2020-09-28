using DesignPatternsLib.AbstractFactory;
using DesignPatternsLib.Adapter;
using DesignPatternsLib.Brigde;
using DesignPatternsLib.Bulider;
using DesignPatternsLib.Composite;
using DesignPatternsLib.Facade;
using DesignPatternsLib.FactoryMethod;
using DesignPatternsLib.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadePresentation builder = new FacadePresentation();

            builder.Main();

            Console.ReadLine();
        }
    }
}
