using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.Composite
{
    public class HyperdiveAssembly : IHyperdrive
    {
        public HyperdiveAssembly(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        private List<IHyperdrive> content = new List<IHyperdrive>();

        public void AddNewEngine(IHyperdrive engine)
        {
            content.Add(engine);
        }

        public void RemoveEngine(IHyperdrive engine)
        {
            content.Remove(engine);
        }

        public string StartHyperdrive()
        {
            string result = $"\n{Name}";

            foreach (IHyperdrive item in content)
            {
                result += item.StartHyperdrive();
            }

            return result;
        }
    }
}
