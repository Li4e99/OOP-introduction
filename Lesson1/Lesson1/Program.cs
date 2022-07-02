using Lesson1;


BankAccount bankAccount = new();
bankAccount.SetBalance(100000000);
bankAccount.SetType (BankAccount.Type.credit);
bankAccount.SetAccountNumber (123);
Console.WriteLine($"Номер счета {bankAccount.GetAccountNumber()}, баланс счета {bankAccount.GetBalance()}, тип счета {bankAccount.GetType()}");
Console.ReadKey(true);

Console.ReadKey(true);

