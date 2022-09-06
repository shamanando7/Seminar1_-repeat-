// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Vvedite koordinatu X");
string numberStringX = Console.ReadLine()!;
int numberX = int.Parse(numberStringX);

int x = numberX;
if (x == 0)
{
    Console.WriteLine("Nekorrectno vvedeny dannye");
    return;
}
Console.WriteLine("Vvedite koordinatu Y");
string numberStringY = Console.ReadLine()!;
int numberY = int.Parse(numberStringY);

int y = numberY;
if (y == 0)
{
   Console.WriteLine("Nekorrectno vvedeny dannye");
   return;
}

int result = 0;

if      (x < 0 && y > 0)
         result = 1;

else if (x > 0 && y > 0)
         result = 2;


else if (x < 0 && y < 0)      
         result = 3;


else if (x > 0 && y < 0)
         result = 4;


Console.WriteLine("tochka nahoditsa v chetverti pod nomerom " + result);