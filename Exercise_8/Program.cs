// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("vvedite pervoe chislo");
string numberString1 = Console.ReadLine()!;
int number1 = int.Parse(numberString1);

Console.WriteLine("vvedite vtoroe chislo");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

if (number1 > number2)
{
    Console.WriteLine("bolshee chislo " + number1);
    Console.WriteLine("menshee chislo " + number2);
}
else
{
    Console.WriteLine("bolshee chislo " + number2);
    Console.WriteLine("menshee chislo " + number1);
}



