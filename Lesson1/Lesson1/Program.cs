using Lesson1;


BankAccount bankAccount = new();
bankAccount.Balance = 100000000;
bankAccount.AccountType = BankAccount.Type.credit;
Console.WriteLine($"Номер счета {bankAccount.BankAcc()}, баланс счета {bankAccount.Balance}, тип счета {bankAccount.AccountType}");

BankAccount bankAccount2 = new();
bankAccount2.Balance = 5000000;
bankAccount2.AccountType = BankAccount.Type.current;
Console.WriteLine($"Номер счета {bankAccount2.BankAcc()}, баланс счета {bankAccount2.Balance}, тип счета {bankAccount2.AccountType}");

BankAccount bankAccount3 = new();
bankAccount3.Balance = 300000;
bankAccount3.AccountType = BankAccount.Type.deposit;
Console.WriteLine($"Номер счета {bankAccount3.BankAcc()}, баланс счета {bankAccount3.Balance}, тип счета {bankAccount3.AccountType}");

Console.ReadKey(true);

