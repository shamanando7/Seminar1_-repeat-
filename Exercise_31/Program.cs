// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] createArray(int length)


{
    var random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
}

int methodchet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void printArray(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr[i] + "]";
        }
    }
    Console.WriteLine(result);
}


Console.Write("Введите размер массива: ");
int digit = int.Parse(Console.ReadLine()!);

int[] array = createArray(digit);
Console.WriteLine("Сгенерировали массив:");
printArray(array);

int result = methodchet(array);
Console.WriteLine("Количество четных чисел: " + result);
