

namespace Task_cs.AtmClass
{
    internal partial  class Card
    {
        private string? Bankname { get; set; }
        private string? Pan;
        private string? Pin;
        private string? Cvc;
        private DateTime ExpireDate { get; set; }
        private decimal Balans;

        public Card()
        {
            Bankname = null;
            Pan = null;
            Pin = null;
            Cvc = null;
            ExpireDate = DateTime.MinValue;
            Balans = 0;
        }

        public Card(string? bankname, string? pan, string? pin, string? cvc, DateTime expireDate, decimal balans)
        {
            Bankname = bankname;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpireDate = expireDate;
            Balans = balans;
        }

        public string PAN
        {
            get { return Pan!; }
            set { if (value.Length == 16) Pan = value;
                else  throw new Exception("PAN 16 reqemden ibaret olmalidir!!") ;
            }
        }

        public string PIN
        {
            get { return Pin!; }
            set
            {
                if (value.Length == 4) Pin = value;
                else throw new Exception("PIN 4 reqemden ibaret olmalidir!!");
            }
        }

        public string CVC
        {
            get { return Cvc!; }
            set
            {
                if (value.Length == 3) Cvc = value;
                else throw new Exception("CVC 3 reqemden ibaret olmalidir!!");
            }
        }
        public decimal BALANS
        {
            get { return Balans; }
            set
            {
                if (value>=0) Balans = value;
                else throw new Exception("Balans 0 AZN-den asagi ola bilmez!!");
            }
        }

        
    }
}
