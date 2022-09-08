// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N


int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i < num+1; i++)
    {
        result = i * result;
    }
    return result;
if (num ==0)
   return 1;
}


// var i,n,s:integer;
// begin
// readln(n);
// s:=1;
// for i:=1 to n do
// s:=s*i;
// writeln(s);
// end.

Console.WriteLine("vvedite chislo");
string numberString = Console.ReadLine();
int number = int.Parse(numberString);

if (number < 0)
return;
int result = Factorial(number);
Console.WriteLine(result);




