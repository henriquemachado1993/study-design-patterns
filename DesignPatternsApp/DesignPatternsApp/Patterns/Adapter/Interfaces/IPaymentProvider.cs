using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.Interfaces
{
    public interface IPaymentProvider
    {
        void MakePayment(string cardNumber, double paymentAmount);
    }
}
