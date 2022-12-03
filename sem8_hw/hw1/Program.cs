// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, cols];
FillArrayRandomNumbers(numbers);
Console.WriteLine("неупорядоченный массив: ");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < numbers.GetLength(1) - 1; x++)
        {
            if (numbers[i, x] < numbers[i, x + 1])
            {
                int temp = 0;
                temp = numbers[i, x];
                numbers[i, x] = numbers[i, x + 1];
                numbers[i, x + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("упорядоченный массив: ");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
