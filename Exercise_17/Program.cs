// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("vvedite chislo");
string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

if (number < 5)
{
    Console.WriteLine("ne yavlyaetsa vyhodnim");
}


else if (number == 6)
{
    Console.WriteLine("yavlyaetsa vyhodnym");
}
else if (number == 7)
{
    Console.WriteLine("yavlyaetsa vyhodnym");
}

else if (number < 1)
{
    Console.WriteLine("vvedeno nekorrectnoe znachenie");
}