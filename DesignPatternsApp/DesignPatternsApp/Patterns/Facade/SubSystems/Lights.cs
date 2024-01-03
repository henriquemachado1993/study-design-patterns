using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Facade.SubSystems
{
    public class Lights
    {
        // Luzes esmaecidas
        public void Dim()
        {
            Console.WriteLine("Luzes dimmed");
        }

        public void On()
        {
            Console.WriteLine("Luzes ligadas");
        }

        public void Off()
        {
            Console.WriteLine("Luzes desligadas");
        }
    }
}
