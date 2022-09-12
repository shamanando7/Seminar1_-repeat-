// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createArray()
{
    var random = new Random();
    var result = new int[8];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 99);
    }
    return result;
}

int SummIndexNechetnyh(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            result += arr[i];
    }
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}


Console.WriteLine("Создали массив");

int[] array = createArray();
printArray(array);


int result = SummIndexNechetnyh(array);
Console.WriteLine("Сумма элементов стоящих на нечетных позициях: " + result);


