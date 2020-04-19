using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContext.Tests.Queries
{
    [TestClass]
    public class StudentQueriesTests
    {
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            for(int i = 0; i <=10; i++)
            {
                _students.Add(new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("11111111111" + i.ToString(), Domain.Enuns.EDocumentType.CPF),
                    new Email(i.ToString() + "@gmail.com")
                    ));
            }
        }

        [TestMethod]
        public void TesteQuerieEstudent()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var st = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, st);
        }


        [TestMethod]
        public void TesteQuerieEstudent1()
        {
            var exp = StudentQueries.GetStudentInfo("11111111111");
            var st = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, st);
        }
    }
}
