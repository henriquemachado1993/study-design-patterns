using DesignPatternsApp.Patterns.Adapter.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter
{
    public class PrinterAdapter : OldPrinter
    {
        private readonly ModernPrinter _modernPrinter;

        public PrinterAdapter(ModernPrinter modernPrinter)
        {
            this._modernPrinter = modernPrinter;
        }

        public new void PrintOld(string text)
        {
            _modernPrinter.Print(text);
        }
    }
}
