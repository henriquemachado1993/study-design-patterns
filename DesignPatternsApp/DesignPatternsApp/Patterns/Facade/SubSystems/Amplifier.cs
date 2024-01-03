using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Facade.SubSystems
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplificador ligado");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume ajustado para {volume}");
        }

        public void Off()
        {
            Console.WriteLine("Amplificador desligado");
        }
    }
}
