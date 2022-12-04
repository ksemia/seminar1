// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());

void FindSum (int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++); 
    FindSum (M, N, sum);
}
FindSum (M, N, 0);