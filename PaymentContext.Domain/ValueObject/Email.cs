using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Email : VObject
    {
        public Email(string address) 
        {
            Address = address;
        }

        public string Address { get; private set;}
    }
}