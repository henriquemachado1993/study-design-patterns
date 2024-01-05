using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Observer
{
    public class ObserverCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Observer");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Observer é um padrão comportamental que define uma dependência um para muitos entre objetos, de modo que quando um objeto sofre uma alteração de estado, todos os seus dependentes são notificados e atualizados automaticamente.");
            Console.WriteLine("Contexto: Portal de notícias");
            Console.WriteLine();

            Console.WriteLine("Portal de notícias - HM");

            // Criando assinantes
            var subscribers = new List<IObserver>();
            while (true)
            {
                Console.WriteLine("Deseja se inscrever? Caso positivo, digite seu nome:");
                var name = Console.ReadLine();
                if(!string.IsNullOrEmpty(name))
                    subscribers.Add(new NewsSubscriber(name));

                Console.WriteLine("Deseja inscrever mais alguém? [S] sim, [N] não");
                if(Console.ReadLine()?.ToUpper() == "N")
                    break;
            }

            // Criando um portal de notícias
            NewsPortal newsPortal = new NewsPortal();

            // Assinando o portal de notícias
            newsPortal.Subscribers(subscribers);

            // Adicionando uma nova notícia
            newsPortal.AddNews("Descoberta científica revolucionária!");

            // Desassinando um assinante
            //newsPortal.Unsubscribe(subscriber);

            // Adicionando outra notícia
            newsPortal.AddNews("Novo avanço na tecnologia espacial!");

            Console.WriteLine();
        }
    }
}
