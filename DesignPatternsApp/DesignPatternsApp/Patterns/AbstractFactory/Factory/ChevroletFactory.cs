using DesignPatternsApp.Patterns.AbstractFactory.ConcreteImplementation;
using DesignPatternsApp.Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.AbstractFactory.Factory
{
    public class ChevroletFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
