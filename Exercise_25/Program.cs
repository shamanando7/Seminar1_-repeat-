// // Напишите программу, которая задает массив из 8 элементов и выводит их на экран.



// Console.WriteLine("Введите размер массива");
// int X = int.Parse(Console.ReadLine()!);

// int[] createArray()
// {
//     var random = new Random();
//     var result = new int[X];

//     for (long i = 0; i < result.Length; i++)
//     {
//         result[i] = random.Next(-9, 10);
//     }
//     return result;
// }


// // Console.WriteLine("Введите размер массива");
// // int Y = int.Parse(Console.ReadLine()!);

// // int[] createArray()
// // {
// //     var random = new Random();
// //     var result = new int[Y];

// //     for (long i = 0; i < result.Length; i++)
// //     {
// //         result[i] = random.Next(-5, 10);
// //     }
// //     return result;
// // }



// // Console.WriteLine("Vvedite razmer massiva");
// // int Q = int.Parse(Console.ReadLine()!);

// // int[] createArray()
// // {
// //     var random = new Random();
// //     var result = new int[Q];

// //     for (long i = 0; i < result.Length; i++)
// //     {
// //         result[i] = random.Next(5, 8);
// //     }
// //     return result;
// // }























// Console.WriteLine("Введите размер массива");
// int X = int.Parse(Console.ReadLine()!);

// int[] createArray()
// {
//     var random = new Random();

//     var result = new int[X];

//     for (long i = 0; i < result.Length; i++)
//     {
//         result[i] = random.Next(-9, 10);
//     }

//     return result;
// }

// void printArray1(int[] array)
// {
//     Console.Write("[");

//     for (var i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);

//         if (i != array.Length - 1)
//             Console.Write(", ");
//     }

//     Console.Write("]");
//     Console.WriteLine();
// }

// var array = createArray();
// printArray1(array);











































// // Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.


// // int SumAllNumbers(int number)
// // {
// //     int index = number.ToString().Length;      // Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление.
// //     int count = 0;
// //     int result = 0;
// //     int digit = number;
// //     while (count < index)
// //     {
// //         digit = number%10;
// //         result = digit + result;
// //         number = number/10;
// //         count++;
// //     }
// //     return result;
// // }

// // Console.WriteLine("vvedite chislo");
// // int digit = int.Parse(Console.ReadLine()!);

// // if (digit == 0)
// // {
// // Console.WriteLine("0");
// // return;
// // }

// // else if (digit < 0)
// // {
// // Console.WriteLine("vvedite polozshitelnoe chislo");
// // return;
// // }
// // Console.WriteLine(SumAllNumbers(digit));













































// // Напишите функцию, которая принимает на вход два числа (А и В) и возводит число А в натуральную степень В.



// // int NaturalStepen(int numberA, int numberB)
// // {
// //     int result = 1;

// //     for (int i = 1; i <= numberB; i++)
// //     {
// //         result = result * numberA;
// //     }
// //     return result;
// // }

// // Console.WriteLine("vvedite chislo A");
// // int A = int.Parse(Console.ReadLine()!);

// // Console.WriteLine("vvedite chislo B");
// // int B = int.Parse(Console.ReadLine()!);

// // int result = NaturalStepen(A, B);
// // if (B < 0)
// //     Console.WriteLine("not");

// // else if (B == 0) 
// // Console.WriteLine("1");

// // else
// //     Console.WriteLine(result);