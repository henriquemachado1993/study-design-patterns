using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.AbstractFactory.Factory;
using DesignPatternsApp.Patterns.AbstractFactory.Interfaces;
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
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão AbstractFactory");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.");
            Console.WriteLine("Contexto: Fábrica de carros.");
            Console.WriteLine();

            // Escolha a fábrica desejada
            ICarFactory fordFactory = new FordFactory();
            ICarFactory chevroletFactory = new ChevroletFactory();

            // Crie carros usando as fábricas
            ICar fordCar = fordFactory.CreateCar();
            ICar chevroletCar = chevroletFactory.CreateCar();

            Console.WriteLine("Carro Ford:");
            Console.WriteLine($"Motor: {fordCar.CreateEngine().TypeEngine()}");
            Console.WriteLine($"Pneu: {fordCar.CreateTire().TypeTire()}");

            Console.WriteLine("\nCarro Chevrolet:");
            Console.WriteLine($"Motor: {chevroletCar.CreateEngine().TypeEngine()}");
            Console.WriteLine($"Pneu: {chevroletCar.CreateTire().TypeTire()}");

            Console.WriteLine();
        }
    }
}
