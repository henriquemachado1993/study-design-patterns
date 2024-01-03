using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Adapter.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter
{
    public class AdapterCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Adapter");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Adapter é usado quando você precisa fazer com que uma interface existente seja compatível com outra interface, mas essas interfaces são incompatíveis inicialmente. Ele atua como uma ponte entre duas interfaces diferentes, permitindo que objetos com interfaces incompatíveis trabalhem juntos.");
            Console.WriteLine("Contexto: Impressão de documentos em Impressora antiga.");
            Console.WriteLine();

            // Sistema antigo usando a classe OldPrinter
            OldPrinter oldPrinter = new OldPrinter();
            oldPrinter.PrintOld("Documento antigo");

            // Integrando a classe ModernPrinter usando o adaptador
            ModernPrinter modernPrinter = new ModernPrinter();
            PrinterAdapter adapter = new PrinterAdapter(modernPrinter);
            adapter.PrintOld("Documento adaptado para o novo sistema");

            Console.WriteLine();
        }

        
    }
}