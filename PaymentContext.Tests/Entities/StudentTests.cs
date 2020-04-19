using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enuns;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student student;
        private readonly Subscription subscription;
        private readonly Document document;
        private readonly Email email;
        private readonly Addres address;
        private readonly Name name;

        public StudentTests()
        {
            name = new Name("Luiz", "Fernando");
            document = new Document("08607576925", EDocumentType.CPF);
            email = new Email("luiz@gmail.com");
            address = new Addres("Rua Antonio Barreto", "61", "86170000", "Sertanopolis", "PR", "Brasil", "1340000");
            student = new Student(name, document, email);
            subscription = new Subscription(null);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, document, "Meta Tecnologia", address, email);

            subscription.AddPayment(payment);

            student.AddSubscription(subscription);
            student.AddSubscription(subscription);

            Assert.IsTrue(student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {
            student.AddSubscription(subscription);

            Assert.IsTrue(student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, document, "Meta Tecnologia", address, email);

            subscription.AddPayment(payment);

            student.AddSubscription(subscription);

            Assert.IsTrue(student.Valid);
        }
    }
}