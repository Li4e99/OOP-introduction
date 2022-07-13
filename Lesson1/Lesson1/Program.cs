using Lesson1;

//5.1
Rational num1 = new Rational(1, 3);
Rational num2 = new Rational(2, 3);

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

if (num1 < num2 == false)
    Console.WriteLine($"{num1} < {num2}");
else
    Console.WriteLine($"{num1} > {num2}");

Console.WriteLine($"{num1.RationalNumber}");



Console.ReadKey(true);


