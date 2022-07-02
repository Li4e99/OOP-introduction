namespace Lesson1
{
    public class BankAccount
    {
        private static int _accNumber = 0;
        private int _AccountNumber;
        private decimal _Balance;
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

        public decimal Balance
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
        public BankAccount(decimal balance)
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
        public BankAccount(decimal balance, Type type)
        {
            _Balance = balance;
            _Type = type;
            BankAcc();
        }
        /// <summary>
        /// Метод для внесения денег
        /// </summary>
        /// <param name="cash">Сумма для внесения</param>
        /// <returns></returns>
        public decimal AddMoney(decimal cash)
        {
            _Balance = _Balance + cash;
            Console.WriteLine($"На Ваш счет зачислено {cash} рублей");
            return _Balance;
        }
        /// <summary>
        /// Метод для снятия денег
        /// </summary>
        /// <param name="cash">Сумма для снятия</param>
        /// <returns></returns>
        public decimal TakeMoney(decimal cash)
        {
            if (_Type != BankAccount.Type.credit)
            {
                if (cash <= _Balance)
                {
                    _Balance = _Balance - cash;
                    Console.WriteLine($"Остаток на Вашем балансе - {_Balance}");
                    return _Balance;
                }
                else
                    Console.WriteLine("Недостаточно средств.");
                return _Balance;
            }
            else
                _Balance = _Balance - cash;
                Console.WriteLine($"Остаток на Вашем балансе - {_Balance}");
            return _Balance;
        }

    }


}

