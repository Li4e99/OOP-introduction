namespace Lesson1
{
    public class BankAccount
    {
        private int _AccountNumber;
        private double _Balance;
        public enum Type { credit, deposit, current }
        private Type _Type;

        public void SetAccountNumber (int accountNumber)
        {
           _AccountNumber= accountNumber;
        }
        public int GetAccountNumber ()
        {
            return _AccountNumber;
        }

        public void SetBalance(int balance)
        {
            _Balance = balance;
        }
        public double GetBalance()
        {
            return _Balance;
        }

        public void SetType(BankAccount.Type type)
        {
            _Type = type;
        }
        public BankAccount.Type GetType()
        {
            return _Type;
        }

      
    }
}
