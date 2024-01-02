using DesignPatternsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.AbstractFactory
{
    public class AbstractFactoryCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão AbstractFactory");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O Singleton é um padrão que garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso para essa instância.");
            Console.WriteLine("Contexto: Jogo de futebol.");


            Console.WriteLine();
        }
    }
}
