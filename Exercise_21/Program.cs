// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int SummaChisel(int num)
{
    int summ = 0;
    for (int i = 1; i < num; i++)
    {
        summ = i + summ;
    }
    return summ;
}

Console.WriteLine("vvedite chislo");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);

if (number <=0)
Console.WriteLine("not correct");
return;

int result = SummaChisel(number);
Console.WriteLine(result);