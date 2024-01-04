using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Strategy.Interfaces;
using DesignPatternsApp.Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsApp.Patterns.Interator.Interfaces;

namespace DesignPatternsApp.Patterns.Interator
{
    public class InteratorCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Interator");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Strategy permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. Isso permite que o cliente escolha dinamicamente o algoritmo a ser usado em tempo de execução. Em outras palavras, você pode ter diferentes estratégias para realizar a mesma tarefa e alternar entre elas facilmente.");
            Console.WriteLine("Contexto: Lista de Tarefas");
            Console.WriteLine();

            Console.WriteLine("Adicione algumas tarefas separando por ponto e vírgula, exemplo: Ler livro; fazer exercícios; Escrever relatório");
            var tasks = Console.ReadLine()?.Split(";")?.ToList() ?? new List<string>();
            
            var taskList = new TaskList();
            foreach (var item in tasks)
            {
                if(!string.IsNullOrEmpty(item))
                    taskList.AddTask(item.Trim());
            }
            
            // Obtendo um iterador para a lista de tarefas
            IIterator iterator = taskList.GetIterator();

            // Iterando sobre as tarefas
            Console.WriteLine();
            Console.WriteLine("Lista de Tarefas:");

            for (string task = iterator.First(); !iterator.IsDone(); task = iterator.Next())
            {
                Console.WriteLine($"- {task}");
            }

            Console.WriteLine();
        }
    }
}
