using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Adapter.ExternalService;
using DesignPatternsApp.Patterns.Adapter.Interfaces;
using DesignPatternsApp.Patterns.Adapter.PaymentAdapter;
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
            Console.WriteLine("Contexto: Métodos de pagamentos.");
            Console.WriteLine();

            Console.WriteLine("Produto: Bicileta aro 26, Valor: R$ 1.500,00");
            Console.WriteLine("Temos dois provedores de pagamento, [1] MercadoLivre e [2] PagSeguro, qual deseja usar?");

            // Criando um objeto do serviço de pagamento externo
            IPaymentProvider externalPaymentService = GetProvider(Console.ReadLine() ?? "1");

            // Criando um adaptador para o serviço de pagamento externo
            IPaymentGateway paymentGatewayAdapter = new PaymentProviderAdapter(externalPaymentService);

            // Usando o serviço de pagamento através do adaptador
            paymentGatewayAdapter.ProcessPayment("CreditCard", 1500m);

            Console.WriteLine();
        }

        private IPaymentProvider GetProvider(string providerId)
        {
            switch (providerId)
            {
                case "1": return new PaymentProviderMercadolivre();
                case "2": return new PaymentProviderPagSeguro();
                default:
                    Console.WriteLine("Por padrão usamos o Mercadolivre caso não seja especificado o provedor!");
                    Console.WriteLine();

                    return new PaymentProviderMercadolivre();
            }
        }
    }
}