using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Facade.SubSystems
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projetor ligado");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Modo widescreen ativado");
        }

        public void Off()
        {
            Console.WriteLine("Projetor desligado");
        }
    }
}
