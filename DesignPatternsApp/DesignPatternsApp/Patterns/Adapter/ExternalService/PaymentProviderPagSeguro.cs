using DesignPatternsApp.Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.ExternalService
{
    public class PaymentProviderPagSeguro : IPaymentProvider
    {
        public void MakePayment(string cardNumber, double paymentAmount)
        {
            Console.WriteLine($"Pagamento de {paymentAmount} processado com o número do cartão {cardNumber} - Provedor PagSeguro");
        }
    }
}
