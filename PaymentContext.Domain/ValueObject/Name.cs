using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Name : VObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}