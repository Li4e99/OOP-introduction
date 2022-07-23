using Lesson1.Bank;

//6.1
BankAccount bankAccount1 = new(100500, BankAccount.Type.credit);
bankAccount1.AccountType = BankAccount.Type.deposit;
BankAccount bankAccount2 = new(100501, BankAccount.Type.deposit);
BankAccount bankAccount3 = new(100500, BankAccount.Type.credit);
BankAccount bankAccount4 = new BankAccount(100500, BankAccount.Type.credit, 2);

Console.WriteLine(bankAccount1 != bankAccount3);
Console.WriteLine(bankAccount3.Equals(bankAccount1));
Console.WriteLine(bankAccount3.Equals(bankAccount4));


//6.2
Figure figure = new Figure();
Console.WriteLine(figure);


Point point1 = new Point(1, 2);
point1.MoveForX(1, 2);
point1.FigureColor = Figure.Color.red;
point1.FigureVisibility = Figure.Visibility.invisible;
Console.WriteLine(point1);

Circle circle1 = new(1, 1, 20);
Console.WriteLine(circle1.GetSquare());

Rectangle rectangle1 = new(1, 1, 10, 15);
Console.WriteLine(rectangle1.GetSquare());




Console.ReadKey(true);


