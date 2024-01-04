using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Adapter.Interfaces;
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

            // Criando uma instância da impressora antiga
            OldPrinter oldPrinter = new OldPrinter();

            // Criando um adaptador para a impressora antiga
            IModernPrinter adapter = new PrinterAdapter(oldPrinter);

            // Utilizando o novo sistema de impressão com a impressora antiga através do adaptador
            ModernPrinter modernSystem = new ModernPrinter(adapter);
            modernSystem.PrintDocument("New document");

            Console.WriteLine();
        }

        
    }
}