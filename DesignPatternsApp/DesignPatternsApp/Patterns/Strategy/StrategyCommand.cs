using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Strategy.Interfaces;
using DesignPatternsApp.Patterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Strategy
{
    public class StrategyCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Strategy");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Strategy permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. Isso permite que o cliente escolha dinamicamente o algoritmo a ser usado em tempo de execução. Em outras palavras, você pode ter diferentes estratégias para realizar a mesma tarefa e alternar entre elas facilmente.");
            Console.WriteLine("Contexto: Jogo de futebol.");
            Console.WriteLine();

            Console.WriteLine("Produto: Bicileta aro 26, Valor: R$ 1.500,00");
            Console.WriteLine("Temos dois métodos de pagamento, [1] Cartão de crédito e [2] PayPal, qual deseja usar?");

            IPaymentStrategy paymentStrategy = GetProvider(Console.ReadLine() ?? "1");
            PaymentProcessor processor = new PaymentProcessor(paymentStrategy);
            processor.ProcessPayment(1500m);

            Console.WriteLine();

            Console.WriteLine("Gostaria de pagar também meu novo computador com PayPal: No valor de R$ 3.500,00");
            IPaymentStrategy paymentStrategyPayPal = GetProvider("2");

            // Mudando dinamicamente a estratégia
            processor.SetPaymentStrategy(paymentStrategyPayPal);
            processor.ProcessPayment(3500m);

            Console.WriteLine();
        }

        private IPaymentStrategy GetProvider(string providerId)
        {
            switch (providerId)
            {
                case "1": return new CreditCardPayment();
                case "2": return new PayPalPayment();
                default:
                    Console.WriteLine("Por padrão usamos o CreditCard caso não seja especificado o provedor!");
                    Console.WriteLine();
                    return new CreditCardPayment();
            }
        }
    }
}
