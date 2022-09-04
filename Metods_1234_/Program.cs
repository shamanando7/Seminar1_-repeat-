

// void Metod1()
// {
//     Console.WriteLine("Autor...");
// }

// Metod1();



// void Metod2 (string msg)
// {
//     Console.WriteLine(msg);
// }

// Metod2 ("what?");


// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//     Console.WriteLine(msg); // где переменная count отображает на экране определенное количество сообщений msg.
//     i++;
//     }
// }

// Metod21(count: 4, msg:"Text");



// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int year = Metod3();
// Console.WriteLine(year);


// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);



// string Metod4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Metod4(10, "asdf");
// Console.WriteLine(res);


// Таблица умножения.

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//      Console.WriteLine();
// }





// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// // это условный 4й метод

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;

//    for (int i = 0; i < length; i++)
//    {
//      if (text [i] == oldValue) result += $"{newValue}";
//      else result += $"{text[i]}";
//    }
//     return result;
// }

// string newText = Replace(text, ' ', '|' );
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'к', 'К' );
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'с', 'С' );
// Console.WriteLine(text);
// Console.WriteLine();


















// // Алгоритм сортировки методом выбора



 // 1. Найти позицию минимального элемента в неотсортированной части массива.
 // 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
 // 3. Повторять пока есть неотсортированные элементы.


// Вывод данных массива на экран


int[] arr={1, 5, 4, 3, 2, 6, 7, 1, 1};               

void PrintArray(int[] array)                      
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}


// Теперь нужно написать метод, который будет упорядочивать наш массив. 


void SelectionSort(int[] array)
{
      
        for (int i = 0; i < array.Length-1; i++)                 // искусственно отнимаем 1, и тогда i+1 из внутреннего цикла даст ровное количество элементов. 
        {
            int minPosition = i;
            for (int j = i+1; j < array.Length; j++)            // данный цикл ищет максимальный элемент. 
            {
                if(array[j] < array[minPosition])
                {
                minPosition = j;
                }
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
}
PrintArray(arr);    
SelectionSort(arr);
PrintArray(arr);        






