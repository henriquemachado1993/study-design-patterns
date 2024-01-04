using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Interator.Interfaces
{
    public interface IIterator
    {
        string First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}
