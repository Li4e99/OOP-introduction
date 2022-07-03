using Lesson1;

BankAccount bankAccount4 = new(100500, BankAccount.Type.credit); //тут пример для задания 2.5 с кредитным счетом
Console.WriteLine($"Баланс {bankAccount4.Balance},номер счета {bankAccount4.AccountNumber}, тип счета {bankAccount4.AccountType}");
bankAccount4.TakeMoney(100500);
Console.WriteLine($"Баланс {bankAccount4.Balance},номер счета {bankAccount4.AccountNumber}, тип счета {bankAccount4.AccountType}");
bankAccount4.AddMoney(1123004);
Console.WriteLine($"Баланс {bankAccount4.Balance},номер счета {bankAccount4.AccountNumber}, тип счета {bankAccount4.AccountType}");
bankAccount4.TakeMoney(1123005);

BankAccount bankAccount5 = new(100500, BankAccount.Type.deposit); //тут пример для задания 2.5 с депощитным счетом
Console.WriteLine($"Баланс {bankAccount5.Balance},номер счета {bankAccount5.AccountNumber}, тип счета {bankAccount5.AccountType}");
bankAccount5.TakeMoney(100500);
Console.WriteLine($"Баланс {bankAccount5.Balance},номер счета {bankAccount5.AccountNumber}, тип счета {bankAccount5.AccountType}");
bankAccount5.AddMoney(1123004);
Console.WriteLine($"Баланс {bankAccount5.Balance},номер счета {bankAccount5.AccountNumber}, тип счета {bankAccount5.AccountType}");
bankAccount5.TakeMoney(1123005);


Console.ReadKey(true);

