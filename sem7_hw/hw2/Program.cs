// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();

Console.WriteLine("номер элемента в строке: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("номер элемента в столбце: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [4,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    int x = numbers[n-1,m-1];
    Console.WriteLine($"значение элемента {x}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine("");
    }
}