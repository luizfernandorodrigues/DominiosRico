using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "wayne";
            command.Document = "99999999999";
            command.Email = "fernando@gmail.com";
            command.BarCode = "123456789";
            command.boletoNumber = "1234567";
            command.PayerNumber = "123121";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60m;
            command.TotalPaid = 60m;
            command.Payer = "Wayne Corp";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = Domain.Enuns.EDocumentType.CPF;
            command.PayerEmail = "empresa@gmail.com";
            command.Street = "Rua teste";
            command.Number = "61";
            command.Neighborhood = "teste";
            command.City = "Sertao";
            command.State = "PR";
            command.Country = "Brasil";
            command.ZipCode = "12345678";

            handler.Handle(command);

            Assert.AreEqual(false, handler.Valid);

    }
}
}
