﻿using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;
using System;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
            throw new NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            if (document == "99999999999")
                return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "luiz@gmail.com")
                return true;

            return false;
        }
    }
}
