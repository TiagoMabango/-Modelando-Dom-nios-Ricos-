using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Email : VObject
    {
        public Email(string address) 
        {
            Address = address;

            AddNotification(new Contract(
                .Requires()
                .IsEmail(Address,"Email.Address","E-mail inválido")
            ));
        }

        public string Address { get; private set;}
    }
}