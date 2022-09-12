// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] createArray()
{
    var random = new Random();
    var result = new int[123];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 123);
    }
    return result;
}

int countElement(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            result++;
    }
    return result;
}

int[] newArray = createArray();
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + ", ");
}




var array = createArray();

Console.WriteLine("Количество элементов: ");

Console.WriteLine(countElement(array));












// решение в семинаре

// int[] createArray()
// {
//     var random = new Random();
//     var result = new int[123];
//     for (long i = 0; i < result.Length; i++)
//     {
//         result[i] = random.Next(0, 123);
//     }
//     return result;
// }



// int countElement(int[] arr, int min, int max)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (arr[i] > min && arr[i] <= max)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// void viewArr(int[] arr)
// {
//     string result = "[";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//         {
//             result += arr[i] + ", ";
//         }
//         if (i == arr.Length - 1)
//         {
//             result += arr[i] + "]";
//         }
//     }
//     Console.WriteLine(result);
// }

// int[] array = createArray();
// viewArr(array);
// Console.WriteLine(searchNumbers(array, 10, 99));
