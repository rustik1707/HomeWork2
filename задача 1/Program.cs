// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трехначное число");
string? num = Console.ReadLine();  
int number = Convert.ToInt32(num);

int x = number / 10;
int y = x % 10;

Console.WriteLine($"вторая цифра {y}");
