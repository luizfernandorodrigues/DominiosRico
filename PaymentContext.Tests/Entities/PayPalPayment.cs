﻿using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Addres address, Email email) 
            : base(paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}