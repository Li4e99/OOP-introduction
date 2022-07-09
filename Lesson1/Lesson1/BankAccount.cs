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
        private static int CreateBankAccNumber()
        {
            
            return _accNumber++;
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
            _AccountNumber = CreateBankAccNumber();
        }
        /// <summary>
        /// Коструктор для заполнения поля баланс
        /// </summary>
        /// <param name="balance"> Баланс счета</param>
        public BankAccount(decimal balance)
        {
            _Balance = balance;
            _Type = Type.current;
            _AccountNumber = CreateBankAccNumber();
        }
        /// <summary>
        /// конструктор для заполнения поля тип банковского счета
        /// </summary>
        /// <param name="type">Тип счета</param>
        public BankAccount(Type type)
        {
            _Type = type;
            _Balance = default;
            _AccountNumber = CreateBankAccNumber();
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
            _AccountNumber = CreateBankAccNumber();
        }
        /// <summary>
        /// Метод для внесения денег
        /// </summary>
        /// <param name="cash">Сумма для внесения</param>
        /// <returns></returns>
        public decimal AddMoney(decimal cash)
        {
            _Balance = _Balance + cash;
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
                    Console.WriteLine($"Остаток на Вашем балансе - {_Balance}");//мне кажется вынести это в Main не правильно, иначе в мейне придется прописывать это каждый раз при срабатывании метода.
                    return _Balance;
                }
                else
                    Console.WriteLine("Недостаточно средств.");//мне кажется вынести это в Main не правильно, иначе в мейне придется прописывать это каждый раз при срабатывании метода.
                return _Balance;
            }
            else
                _Balance = _Balance - cash;
                Console.WriteLine($"Остаток на Вашем балансе - {_Balance}");//мне кажется вынести это в Main не правильно, иначе в мейне придется прописывать это каждый раз при срабатывании метода.
            return _Balance;
        }
        /// <summary>
        /// Метод для перевода средств на другой счет
        /// </summary>
        /// <param name="account">Аккаунт откуда переводим деньги</param>
        /// <param name="cash">Сумма для перевода</param>
        /// <returns></returns>
        public decimal MoveCash(BankAccount account, decimal cash)
        {
            account._Balance = account._Balance - cash;
            _Balance = _Balance + cash;
            Console.WriteLine($"Поступил перевод со счета {account._AccountNumber} на сумму {cash}"); //мне кажется вынести это в Main не правильно, иначе в мейне придется прописывать это каждый раз при срабатывании метода.
            return _Balance;
        }

    }


}

