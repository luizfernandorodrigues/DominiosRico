using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;

            _subscriptions = new List<Subscription>();
        }

        #region Propriedades
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private  set; }
        public Addres Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        #endregion Propriedades

        #region Métodos Publicos
        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Inactivate();

            _subscriptions.Add(subscription);

        }
        #endregion Métodos Publicos
    }
}