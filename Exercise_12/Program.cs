// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 

Console.WriteLine("vvedite pervoe chislo");
string numberstring1 = Console.ReadLine()!;
int number1 = int.Parse(numberstring1);

Console.WriteLine("vvedite vtoroe chislo");
string numberstring2 = Console.ReadLine()!;
int number2 = int.Parse(numberstring2);

int ostatok = number2%number1;

if (number2%number1 == 0)
   {
Console.WriteLine("chislo yavlaetsa kratnym");
   }

else
{
Console.WriteLine("chislo ne yavlaetsa kratnym");
Console.WriteLine("ostatok " + ostatok);
}

