using Lesson1;

//6.1
BankAccount bankAccount1 = new(100500, BankAccount.Type.credit);
BankAccount bankAccount2 = new(100501, BankAccount.Type.deposit);
BankAccount bankAccount3 = new(100500, BankAccount.Type.credit);
BankAccount bankAccount4 = new BankAccount(100500, BankAccount.Type.credit, 2);

Console.WriteLine(bankAccount1!=bankAccount3);
Console.WriteLine(bankAccount3.Equals(bankAccount1));
Console.WriteLine(bankAccount3.Equals(bankAccount4));


Console.ReadKey(true);


