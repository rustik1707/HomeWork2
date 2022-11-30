// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int numDigit = NumberDigit(number);

if (numDigit <= 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{

    if (numDigit > 3)
    {
        number = number / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра введённого числа: {number}");
}
