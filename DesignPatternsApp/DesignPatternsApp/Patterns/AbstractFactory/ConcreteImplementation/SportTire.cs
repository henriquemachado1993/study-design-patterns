using DesignPatternsApp.Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.AbstractFactory.ConcreteImplementation
{
    public class SportTire : ITire
    {
        public string TypeTire()
        {
            return "Pneu esportivo";
        }
    }
}
