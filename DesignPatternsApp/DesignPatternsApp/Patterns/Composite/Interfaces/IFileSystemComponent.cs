using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Composite.Interfaces
{
    public interface IFileSystemComponent
    {
        string GetName();
        void Display(string prefix = "");
    }
}
