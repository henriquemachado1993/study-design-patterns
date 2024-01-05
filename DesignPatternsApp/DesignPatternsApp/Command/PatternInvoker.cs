using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.AbstractFactory;
using DesignPatternsApp.Patterns.Adapter;
using DesignPatternsApp.Patterns.Composite;
using DesignPatternsApp.Patterns.Facade;
using DesignPatternsApp.Patterns.FactoryMethod;
using DesignPatternsApp.Patterns.Interator;
using DesignPatternsApp.Patterns.Observer;
using DesignPatternsApp.Patterns.Singleton;
using DesignPatternsApp.Patterns.Strategy;

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
            patternCommands.Add("5", new AdapterCommand());
            patternCommands.Add("6", new CompositeCommand());
            patternCommands.Add("7", new StrategyCommand());
            patternCommands.Add("8", new InteratorCommand());
            patternCommands.Add("9", new ObserverCommand());
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
