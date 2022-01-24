using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject
{
    public class Document : VObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotification(new Contract()
                .Requires()
                .IsTrue(Validate(),"Document.Number","Documento inválido!")
            );
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate(){

            if(Type == EDocumentType.CNPJ && Number.Length == "14")
                return true;

            if(Type == EDocumentType.CNPJ && Number.Length == "11")
                return true;
            
            return false;
        }
    }
}