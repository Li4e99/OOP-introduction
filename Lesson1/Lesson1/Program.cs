using Lesson1;


BankAccount bankAccount = new();
bankAccount.Balance = 100000000;
bankAccount.AccountType = BankAccount.Type.credit;
bankAccount.AccountNumber = "0000_0000_0000_0000";
Console.WriteLine($"Номер счета {bankAccount.AccountNumber}, баланс счета {bankAccount.Balance}, тип счета {bankAccount.AccountType}");
Console.ReadKey(true);
