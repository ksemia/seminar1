// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// матрица => тот же массив, 1ая часть - задать массивы, потом заполнить рандомными числами и вывести на экран

using static System.Console;
Clear();

int size = InputInt("размер матриц: ");
Console.WriteLine("Матрица 1: ");
int[,] matrixone = new int[size, size];
Console.WriteLine("Матрица 2: ");
int[,] matrixtwo = new int[size, size];
int[,] matrixNEW = new int[size, size];
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int x = 0; x < size; x++)
        {
            matrixNEW[i, j] = matrixNEW[i, j] + (matrixone[i, x] * matrixtwo[x, j]);
        }
        Console.WriteLine("Произведение матриц: ");
        PrintArray(matrixNEW);
    }
}
FillArrayRandomNumbers(matrixone);
FillArrayRandomNumbers(matrixtwo);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
PrintArray(matrixNEW);

//дает забить данные, но выводит одни нули