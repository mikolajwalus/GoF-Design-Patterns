using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Composite
{
    public class SingleHyperdive : IHyperdrive
    {
        public SingleHyperdive(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void AddNewEngine(IHyperdrive engine)
        {
            throw new NotImplementedException();
        }

        public void RemoveEngine(IHyperdrive engine)
        {
            throw new NotImplementedException();
        }

        public string StartHyperdrive()
        {
            return $"\nEngine: {Name} has started";
        }
    }
}
