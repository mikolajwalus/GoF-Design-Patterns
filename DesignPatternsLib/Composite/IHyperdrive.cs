using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Composite
{
    public interface IHyperdrive
    {
        string Name { get; set; }
        string StartHyperdrive();
        void AddNewEngine(IHyperdrive engine);
        void RemoveEngine(IHyperdrive engine);
    }
}
