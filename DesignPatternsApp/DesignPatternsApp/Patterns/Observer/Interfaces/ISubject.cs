using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Observer.Interfaces
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Subscribers(List<IObserver> observers);
        void Unsubscribe(IObserver observer);
        void NotifySubscribers(string news);
    }
}
