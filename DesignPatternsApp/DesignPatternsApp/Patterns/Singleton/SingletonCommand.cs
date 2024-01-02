using DesignPatternsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Singleton
{
    public class SingletonCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Singleton");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O Singleton é um padrão que garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso para essa instância.");
            Console.WriteLine("Contexto: Jogo de futebol.");

            Singleton Player1 = Singleton.GetInstance;
            Player1.WriteMessage("Jogador 1: A bola está comigo");
            Singleton Player2 = Singleton.GetInstance;
            Player2.WriteMessage("Jogador 2: Recebeu a bola");
            Singleton Player3 = Singleton.GetInstance;
            Player3.WriteMessage("Jogador 3: Toca a bola para mim");

            Console.WriteLine();
        }
    }

    public sealed class Singleton
    {
        private static Singleton Instance;
        private static Guid InstanceId = Guid.Empty;

        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                    InstanceId = Guid.NewGuid();
                    Console.WriteLine();
                    Console.WriteLine($"Instância criada: {InstanceId}");
                }
                return Instance;
            }
        }

        public void WriteMessage(string text)
        {
            Console.WriteLine($"{text} - Instância usada: {InstanceId}");
        }
    }
}
