using DesignPatternsApp.Patterns.Adapter.ExternalService;
using DesignPatternsApp.Patterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.PaymentAdapter
{
    public class PaymentProviderAdapter : IPaymentGateway
    {
        private IPaymentProvider _paymentProvider;

        public PaymentProviderAdapter(IPaymentProvider paymentProvider)
        {
            this._paymentProvider = paymentProvider;
        }

        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            // Faz a adaptacão a do método existente para a interface esperada
            string cardNumber = GetCardNumberFromPaymentMethod(paymentMethod);
            double doubleAmount = Convert.ToDouble(amount);
            _paymentProvider.MakePayment(cardNumber, doubleAmount);
        }

        private string GetCardNumberFromPaymentMethod(string paymentMethod)
        {
            // Aqui pode ser implementado a lógica para obter o método de pagamento
            return "1234-5678-9012-3456";
        }
    }
}
