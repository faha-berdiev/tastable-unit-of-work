﻿using System;

namespace App.PaymentService
{
    public interface IPaymentService : IDisposable
    {
        void DebitPayment(decimal amount, string customerCard);
        void CreditPayment(decimal amount, string customerCard);
    }
}