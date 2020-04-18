using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Addres address, Email email) 
            : base(paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}