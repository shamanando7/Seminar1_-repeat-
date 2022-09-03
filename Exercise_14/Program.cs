// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом второго.


Console.WriteLine("vvedite pervoe chislo");
string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

Console.WriteLine("vvedite vtoroe chislo");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

if (number*number == number2)
{
   Console.WriteLine("chislo yavlaetsa kvadratom"); 
}

else
{
   Console.WriteLine("chislo ne yavlaetsa kvadratom"); 
}