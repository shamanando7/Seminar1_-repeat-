// //  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// Random random = new Random();
// int randomNumber = random.Next(100,1000);

// Console.WriteLine(randomNumber);

// int firstDigit = randomNumber / 100;
// int secondDigit = randomNumber % 10;


// Console.Write(firstDigit);
// Console.Write(secondDigit);

Random random2 = new Random();
int randomNumber2 = random2.Next(100,1000);
Console.WriteLine(randomNumber2);

int number1 = randomNumber2/100;
int number2 = randomNumber2%10;

Console.WriteLine("reshenie " + number1 + number2);