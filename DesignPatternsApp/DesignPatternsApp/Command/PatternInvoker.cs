using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.AbstractFactory;
using DesignPatternsApp.Patterns.Facade;
using DesignPatternsApp.Patterns.FactoryMethod;
using DesignPatternsApp.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Command
{
    public class PatternInvoker
    {
        private Dictionary<string, IPatternCommand> patternCommands = new Dictionary<string, IPatternCommand>();

        public PatternInvoker()
        {
            patternCommands.Add("1", new SingletonCommand());
            patternCommands.Add("2", new FactoryMethodCommand());
            patternCommands.Add("3", new AbstractFactoryCommand());
            patternCommands.Add("4", new FacadeCommand());
        }

        public void ExecuteCommand(string? patternId)
        {
            if (string.IsNullOrEmpty(patternId) || !patternCommands.TryGetValue(patternId, out var command))
                Console.WriteLine("Padrão não reconhecido.");
            else
                command.Execute();
        }

        public void ExecuteAllCommand()
        {
            if (!patternCommands.Any())
                Console.WriteLine("Não há padrões a serem executados.");
            else
            {
                foreach (var command in patternCommands)
                {
                    command.Value.Execute();
                }
            }
        }
    }
}
