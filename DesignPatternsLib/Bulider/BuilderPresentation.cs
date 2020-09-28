using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Bulider
{
    public class BuilderPresentation
    {
        public void Main()
        {
            var facility = new KaminoFacility();
            var builder = new VentatorCruiserBuilder();

            facility._builder = builder;

            facility.CreateFullCruiser();

            builder.ventatorCruiser.ShowFeatures();
        }

    }
}
