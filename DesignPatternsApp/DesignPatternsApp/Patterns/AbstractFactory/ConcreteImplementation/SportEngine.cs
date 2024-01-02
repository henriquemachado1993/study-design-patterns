﻿using DesignPatternsApp.Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.AbstractFactory.ConcreteImplementation
{
    public class SportEngine : IEngine
    {
        public string TypeEngine()
        {
            return "Motor esportivo";
        }
    }
}
