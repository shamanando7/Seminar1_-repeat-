// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



int[] createArray()
{
    var random = new Random();
    var result = new int[15];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-100, 100);
    }
    return result;

}

void PositiveZamena(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}



var array = createArray();                 // Создается массив
for (int i = 0; i < array.Length; i++)     // Массив выводится
{
    Console.Write(array[i] + ", ");
}

PositiveZamena(array);                     // Вызывается функция (никакое значение не присваивается потому что 
Console.WriteLine();                       // функция void(просто меняются данные в массиве, того массива который в нее передан)) 
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}




