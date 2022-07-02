namespace Lesson1
{
    public class BankAccount
    {
        private static int _accNumber = 0;
        private int _AccountNumber;
        private double _Balance;
        public enum Type { credit, deposit, current }
        private Type _Type;

        public int BankAcc()
        {
            _AccountNumber = _accNumber++;
            return _AccountNumber;
        }
        public int AccountNumber
        {
            get => _AccountNumber;
        }

        public double Balance
        {
            get => _Balance;
        }

        public Type AccountType
        {
            get { return _Type; }
        }
        public BankAccount()
        {
            _AccountNumber = 0;
            _Balance = 0;
            _Type = Type.current;
            BankAcc();
        }

        public BankAccount( double balance)
        {
            _Balance = balance;
            _Type = Type.current;
            BankAcc();
        }

        public BankAccount(Type type)
        {
            _Type = type;
            _Balance = default;
            BankAcc();
        }
        public BankAccount(double balance,Type type)
        {
            _Balance = balance;
            _Type = type;
            BankAcc();
        }

    }
}
