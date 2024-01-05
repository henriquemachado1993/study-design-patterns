using DesignPatternsApp.Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Observer
{
    public class NewsPortal : ISubject
    {
        private List<IObserver> _subscribers = new List<IObserver>();

        public void NotifySubscribers(string news)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(news);
            }
        }

        public void Subscribe(IObserver observer)
        {
            if(observer != null)
                _subscribers.Add(observer);
        }

        public void Subscribers(List<IObserver> observers)
        {
            if(observers != null && observers.Any())
                _subscribers.AddRange(observers);
        }

        public void Unsubscribe(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

        // Método para adicionar uma nova notícia
        public void AddNews(string news)
        {
            Console.WriteLine($"Nova Notícia: {news}\n");
            NotifySubscribers(news);
        }

    }
}
