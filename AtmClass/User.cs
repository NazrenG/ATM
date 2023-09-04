
namespace Task_cs.AtmClass
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Card? CreditCard { get; set; }

        public User()
        {
            Name = null;
            Surname = null;
            CreditCard = null;
        }

        public User(string? name, string? surname, Card? creditCard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditCard;
        }
        public decimal CardBalance => CreditCard!.BALANS;
        public string CardPan => CreditCard!.PAN;
        public string CardPin => CreditCard!.PIN;
        

       
    }
}
