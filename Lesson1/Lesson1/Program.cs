using Lesson1;


BankAccount bankAccount1 = new();

Console.WriteLine($"Баланс {bankAccount1.Balance},номер счета {bankAccount1.AccountNumber}, тип счета {bankAccount1.AccountType}");

BankAccount bankAccount2 = new(1005.21);

Console.WriteLine($"Баланс {bankAccount2.Balance},номер счета {bankAccount2.AccountNumber}, тип счета {bankAccount2.AccountType}");

BankAccount bankAccount3 = new(BankAccount.Type.deposit);

Console.WriteLine($"Баланс {bankAccount3.Balance},номер счета {bankAccount3.AccountNumber}, тип счета {bankAccount3.AccountType}");

BankAccount bankAccount4 = new(312.2323, BankAccount.Type.credit);

Console.WriteLine($"Баланс {bankAccount4.Balance},номер счета {bankAccount4.AccountNumber}, тип счета {bankAccount4.AccountType}");

Console.ReadKey(true);

