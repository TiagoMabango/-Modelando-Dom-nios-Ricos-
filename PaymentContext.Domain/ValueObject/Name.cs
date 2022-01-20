using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Name : VObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirstName", "Nome inválido!");

            if(string.IsNullOrEmpty(LastName))
                AddNotification("Name.LastName", "Sobrenome inválido!");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}