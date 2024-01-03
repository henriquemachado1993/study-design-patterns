using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Strategy.Interfaces
{
    // Interface comum para as estratégias de processamento de pagamento
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
