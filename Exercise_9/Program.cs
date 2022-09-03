// Найти максимальное из трех чисел.


// Console.WriteLine("vvedite pervoe chislo");
// string numberString1 = Console.ReadLine()!;
// int number1 = int.Parse(numberString1);

// Console.WriteLine("vvedite vtoroe chislo");
// string numberString2 = Console.ReadLine()!;
// int number2 = int.Parse(numberString2);

// Console.WriteLine("vvedite tret'e chislo");
// string numberString3 = Console.ReadLine()!;
// int number3 = int.Parse(numberString3);


// if (number1 > number2 && number1 > number3)
// {
//     Console.WriteLine("max " + number1);
// }

// else if (number2 > number3)
// {
//          Console.WriteLine("max " + number2);
// }

// else
// {
//     Console.WriteLine("max " + number3);
// }


Console.WriteLine("vvedite pervoe chislo");
string numberString1 = Console.ReadLine()!;
int number1 = int.Parse(numberString1);

Console.WriteLine("vvedite vtoroe chislo");
string numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

Console.WriteLine("vvedite tret'e chislo");
string numberString3 = Console.ReadLine()!;
int number3 = int.Parse(numberString3);

int max = number1;

if (max < number2)
    max = number2;
else 
max = number1;

if (max < number3)
    max = number3;
  
Console.WriteLine(max);


















