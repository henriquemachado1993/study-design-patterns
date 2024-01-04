using DesignPatternsApp.Patterns.Adapter.Interfaces;
using DesignPatternsApp.Patterns.Adapter.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter
{
    public class PrinterAdapter : IModernPrinter
    {
        private readonly OldPrinter _oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string document)
        {
            _oldPrinter.PrintOld(document);
        }
    }
}
