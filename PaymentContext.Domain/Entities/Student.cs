using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscription;  
        public Student(Name name,Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();

            AddNotification(name,document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscription.ToArray();} }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
             sub.Inactivate();   

            _subscription.Add(subscription);
        }
    }

}