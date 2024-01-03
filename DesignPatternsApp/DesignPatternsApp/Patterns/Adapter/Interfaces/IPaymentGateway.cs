﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Adapter.Interfaces
{
    public interface IPaymentGateway
    {
        void ProcessPayment(string paymentMethod, decimal amount);
    }
}