// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int index = 1;


while (x >= index)
{
  var result = Math.Pow(index, 2);
  index++;
  Console.WriteLine(result + " ");
  Console.WriteLine(" ");
}

if (x < 1)
  Console.WriteLine("Введены неверные значения");



 




