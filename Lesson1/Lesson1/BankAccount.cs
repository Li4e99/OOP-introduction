namespace Lesson1
{
    public class BankAccount
    {
        private static int _accNumber = 0;
        private int _AccountNumber;
        private double _Balance;
        public enum Type { credit, deposit, current }
        private Type _Type;
        /// <summary>
        /// Метод для генерации уникального номера карты
        /// </summary>
        /// <returns></returns>
        public int BankAcc()
        {
            _AccountNumber = _accNumber++;
            return _AccountNumber;
        }
        public int AccountNumber
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
        /// <summary>
        /// Конструктор дефолтный
        /// </summary>
        public BankAccount()
        {
            _AccountNumber = 0;
            _Balance = 0;
            _Type = Type.current;
            BankAcc();
        }
        /// <summary>
        /// Коструктор для заполнения поля баланс
        /// </summary>
        /// <param name="balance"> Баланс счета</param>
        public BankAccount( double balance)
        {
            _Balance = balance;
            _Type = Type.current;
            BankAcc();
        }
        /// <summary>
        /// конструктор для заполнения поля тип банковского счета
        /// </summary>
        /// <param name="type">Тип счета</param>
        public BankAccount(Type type)
        {
            _Type = type;
            _Balance = default;
            BankAcc();
        }
        /// <summary>
        /// конструктор для заполнения баланса и типа банковского счета
        /// </summary>
        /// <param name="balance">Баланс счета</param>
        /// <param name="type">Тип счета</param>
        public BankAccount(double balance,Type type)
        {
            _Balance = balance;
            _Type = type;
            BankAcc();
        }

    }
}
