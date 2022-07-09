using Lesson1;

//3.1
BankAccount bankAccount4 = new(100500, BankAccount.Type.credit); //тут пример для задания 2.5 с кредитным счетом
Console.WriteLine($"Баланс {bankAccount4.Balance},номер счета {bankAccount4.AccountNumber}, тип счета {bankAccount4.AccountType}");

BankAccount bankAccount5 = new(100500, BankAccount.Type.deposit); //тут пример для задания 2.5 с депощитным счетом
Console.WriteLine($"Баланс {bankAccount5.Balance},номер счета {bankAccount5.AccountNumber}, тип счета {bankAccount5.AccountType}");

bankAccount5.MoveCash(bankAccount4, 500);
Console.WriteLine($"Баланс {bankAccount5.Balance},номер счета {bankAccount5.AccountNumber}, тип счета {bankAccount5.AccountType}");

//3.2
StringChanger stringChanger = new();
Console.WriteLine($"{stringChanger.Reverse("Леша на полке клопа нашел")}");

// 3.3
string[] text = new string[2];
text[0] = "Кучма Андрей Витальевич & Kuchma@mail.ru";
text[1] = "Мизинцев Павел Николаевич & Pasha@mail.ru";

File.WriteAllLines("text.txt", text);
string filename = "text.txt";
string[] fileLines = File.ReadAllLines(filename);
for (int i = 0; i < fileLines.Length; i++)
    fileLines[i] = fileLines[i].Trim();

text text1 = new(fileLines[0]);
text text2 = new(fileLines[1]);

string[] emails = new string[2];
emails[0] = text1.Email;
emails[1] = text2.Email;

File.WriteAllLines("text2.txt", emails);
Console.WriteLine("Создан файл text2.txt со списком e-mails.");
Console.ReadKey(true);

Console.ReadKey(true);


