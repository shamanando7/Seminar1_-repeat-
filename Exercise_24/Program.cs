// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArray()
{
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 2);

    return array;
}


var array =
CreateArray(); 
for (int i = 0; i < 8; i++)
    Console.Write(array[i]);

// создали функцию которая создает массив и выводит на экран.










// int SumAllNumbers(int number)
// {
//     int index = number.ToString().Length;      // Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление.
//     int count = 0;
//     int result = 0;
//     int digit = number;
//     while (count < index)
//     {
//         digit = number % 10;
//         result = digit + result;
//         number = number/ 10;
//         count++;
//     }
//     return result;
// }

// Console.WriteLine("vvedite chislo");
// int digit = int.Parse(Console.ReadLine()!);

// if (digit == 0)
// {
//     Console.WriteLine("0");
//     return;
// }
// else if (digit < 0)
// {
//     //  digit = digit * -1;
//     Console.WriteLine("vvedite polozshitelnoe chislo");
//     return;
// }

// Console.WriteLine(SumAllNumbers(digit));
