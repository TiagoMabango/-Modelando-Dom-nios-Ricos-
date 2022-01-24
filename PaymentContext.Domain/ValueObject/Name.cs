using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Name : VObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotification(new Contract()
                .Requires()
                .HasMinLen(FirstName,3,"Name.FirstName","Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName,3,"Name.LastName","Nome deve conter pelo menos 3 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}