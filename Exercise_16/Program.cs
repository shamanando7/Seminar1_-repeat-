// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 


Console.WriteLine("Пожалуйста, введите целое число");
int numberA = int.Parse(Console.ReadLine()!);

while (numberA > 1000)
{
    numberA = numberA / 10;
}


int numberB = numberA / 100;

if (numberB == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int numberC = numberA - ((numberA / 10) * 10);
    Console.WriteLine("Третья цифра введенного числа " + numberC);
}