// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координатy x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координатy x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());



double AB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));

Console.WriteLine("Расстояние между двумя точками " + AB.ToString("N2")); // округление



// мое творение. 
// найти квадратный корень:

// int a = 25;
// int sqrt = (int) Math.Sqrt(a);
// Console.WriteLine(sqrt);




// или

// int a = 25;
// double sqrt = (int) Math.Sqrt(a);
// Console.WriteLine(sqrt);