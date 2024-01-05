using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Observer.Interfaces
{
    public interface IObserver
    {
        void Update(string news);
    }
}
