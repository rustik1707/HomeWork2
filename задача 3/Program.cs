// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
if (number > 7 || number <= 0)
{
  Console.WriteLine("такого дня нет");  
}
if (number == 6 || number == 7 )
{
 Console.WriteLine("да");   
} else {
    Console.WriteLine("нет");
}
