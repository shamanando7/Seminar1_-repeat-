// Выяснить является ли число четным. 

Console.WriteLine("vvedite chislo");
string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

if (number%2 == 0)
{
    Console.WriteLine("chetnoe");
}
else
{
    Console.WriteLine("ne chetnoe");
}