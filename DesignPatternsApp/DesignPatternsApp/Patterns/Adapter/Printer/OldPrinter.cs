using DesignPatternsApp.Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.Printer
{
    public class OldPrinter
    {
        public void PrintOld(string document)
        {
            Console.WriteLine($"Imprimindo: {document}");
        }
    }
}
