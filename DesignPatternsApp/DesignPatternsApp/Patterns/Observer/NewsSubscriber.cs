using DesignPatternsApp.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Observer
{
    /// <summary>
    /// Assinantes com o observador
    /// </summary>
    public class NewsSubscriber : IObserver
    {
        private string Name;
        public NewsSubscriber(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Implementação do observador
        /// </summary>
        /// <param name="news"></param>
        public void Update(string news)
        {
            Console.WriteLine($"{Name} recebeu a seguinte notícia: {news}");
        }
    }
}
