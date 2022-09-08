// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

int Coldigit(int num)
{

    if (num == 0)
        return 1;

    int result = 0;
    while (num > 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}

// return -1;  это на случай ошибки, т.к все пути кода должны возвращать значение. 



// for (int i = 1; ; i++)         // Цикл for
// {
//     num = num / 10;          
//     if (num == 0)
//         return i;
//     {

//     }
// }
        
    

// if (int.TryParse(Console.ReadLine()!, out int number1)) 
// {
    
//     if (number1 <= 0)
//     {    return;
//      int result = 0;
//     result = Coldigit(number1);
//     Console.WriteLine(result);
//     }
// else
// {
//     Console.WriteLine("vvedeno ne chislo ili slishkom bolshoe chislo");
// }
// }

Console.WriteLine("vvedite chislo");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);

int result1 = Coldigit(number);
Console.WriteLine(result1);