using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShoulReturnErrorWhenNameIsInvalid()
        {
            var comand = new CreateBoletoSubscriptionCommand();
            comand.FirstName = "";

            comand.Validate();
            Assert.AreEqual(false, comand.Valid);
        }
    }
}