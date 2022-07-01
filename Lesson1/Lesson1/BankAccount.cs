namespace Lesson1
{
    public class BankAccount
    {
        private string _AccountNumber;
        private double _Balance;
        public enum Type { credit, deposit, current }
        private Type _Type;

        public string AccountNumber
        {
            get => _AccountNumber;
            set => _AccountNumber = value;
        }

        public double Balance
        {
            get => _Balance;
            set => _Balance = value;
        }

        public Type AccountType
        {
            get { return _Type; }
            set => _Type = value;
        }
        
          
    }
}
