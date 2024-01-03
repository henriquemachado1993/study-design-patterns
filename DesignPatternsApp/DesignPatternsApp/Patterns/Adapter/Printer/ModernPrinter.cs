using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.Printer
{
    public class ModernPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Imprimindo de maneira moderna: {text}");
        }
    }
}
