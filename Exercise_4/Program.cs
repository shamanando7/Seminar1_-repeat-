// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> "-2, -1, 0, 1, 2"

// Console.WriteLine("Введите число и нажмите Enter"); 

// string numberString = Console.ReadLine()!;
// int number = int.Parse(numberString);

// if (number < 0)
//     number *= (-1);     // сначала умножаем, потом присваиваем, тоже самое что и number = number * (-1), т.е мы number умножаем на -1 и потом сохраняем number
//                         // ! если у вас было число отрицательным, то нужно его сначала сделать положительным, потом снова отрицательным.

// int i = number * (-1);   

// while (i<=number) {     // тут уже происходит остановка до введенного числа (number)
//     Console.WriteLine(i++);
// } 



// Console.WriteLine("Vvedite chislo");
// string numberString1 = Console.ReadLine()!;
// int number1 = int.Parse(numberString1);

// if (number1 < 0)
//     number1 = number1*(-1); // prevraschenie otricatelnogo chisla v polozchitelnoe

// int i = number1*(-1); // zdes chislo stanivitsa otricatelnym

// while (i <=number1)
// {
//     Console.WriteLine(i);
//     i++;
// }


Console.WriteLine("vvedite chislo");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

if (number2 < 0)
    number2 = number2 * (-1);

    int i2 = number2 * (-1);

while (i2<=number2)
{
    Console.WriteLine(i2);
    i2++;
}