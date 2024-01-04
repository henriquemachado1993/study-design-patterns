using DesignPatternsApp.Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.Printer
{
    public class ModernPrinter
    {
        private readonly IModernPrinter modernPrinter;

        public ModernPrinter(IModernPrinter modernPrinter)
        {
            this.modernPrinter = modernPrinter;
        }

        public void PrintDocument(string document)
        {
            modernPrinter.Print(document);
        }
    }
}
