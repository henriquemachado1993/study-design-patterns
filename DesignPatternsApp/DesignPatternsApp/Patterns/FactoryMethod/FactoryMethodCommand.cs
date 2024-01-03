using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.FactoryMethod.Abstract;
using DesignPatternsApp.Patterns.FactoryMethod.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.FactoryMethod
{
    public class FactoryMethodCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão FactoryMethod");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: Este padrão define uma interface para a criação de um objeto, mas deixa as subclasses decidirem qual a classe a instanciar. Este padrão permite que uma classe adie a instanciação para subclasses.");
            Console.WriteLine("Contexto: Personagens de jogo de FPS.");
            Console.WriteLine();

            Creator[] creators = new Creator[2];
            creators[0] = new CreatorBangalore();
            creators[1] = new CreatorOctane();

            foreach (Creator creator in creators)
            {
                Character character = creator.FactoryMethod();
                Console.WriteLine("Personagem criado: Id: {0}, Descrição: {1}", character.Id, character.Description);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
