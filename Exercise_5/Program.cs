// Программа которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

//456 -> 6

Console.WriteLine("Vvedite chislo");
string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

int i = number%10;

Console.WriteLine(i);

