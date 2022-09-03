// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели");
string? numberString = Console.ReadLine()!;
int number1 = int.Parse(numberString);
Console.WriteLine();

if (number1 == 1) 
   {
    Console.WriteLine("monday");
   } 
else if (number1 == 2)
   {
    Console.WriteLine("thuesday");
   }
   
else if (number1 == 3)
   {
    Console.WriteLine("wednesday");
   }
   
else if (number1 == 4)
   {
    Console.WriteLine("thursday");
   }
   
else if (number1 == 5)
   {
    Console.WriteLine("friday");
   }
   
else if (number1 == 6)
   {
    Console.WriteLine("saturday");
   }
   
else if (number1 == 7)
   {
    Console.WriteLine("sunday");
   }
else
   {
    Console.WriteLine("некорректно введены данные");
   }
   