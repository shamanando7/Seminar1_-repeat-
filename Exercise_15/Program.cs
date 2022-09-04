// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("vvedite trehznachnoe chislo");
string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

int firstDigit =  number/10;
int secondDigit = firstDigit%10;

Console.WriteLine(secondDigit);