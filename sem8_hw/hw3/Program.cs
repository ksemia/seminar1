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
// вар 1 дает забить данные, но выводит одни нули
//int size = InputInt("размер матриц: ");
//Console.WriteLine("Матрица 1: ");
//int[,] matrixone = new int[size, size];
//Console.WriteLine("Матрица 2: ");
//int[,] matrixtwo = new int[size, size];
//int[,] matrixNEW = new int[size, size];
//int InputInt(string output)
//{
//    Console.Write(output);
//    return int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < size; i++)
//{
//    for (int j = 0; j < size; j++)
//    {
//        for (int x = 0; x < size; x++)
//        {
//            matrixNEW[i, j] = matrixNEW[i, j] + (matrixone[i, x] * matrixtwo[x, j]);
//        }
//        Console.WriteLine("Произведение матриц: ");
//        PrintArray(matrixNEW);
//    }
//}
//FillArrayRandomNumbers(matrixone);
//FillArrayRandomNumbers(matrixtwo);
//void FillArrayRandomNumbers(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(1, 10);
//        }
//    }
//}
//void PrintArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine("");
//    }
//}
//PrintArray(matrixNEW);

//вар 2 от преподавателя
WriteLine("Введите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("укажите количество столбцов и строк 1ой матрицы : ");
int s = InputNumbers("Введите количество строк 2-й матрицы: ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 0 до: ");
int[,] firstMartrix = new int[m, n];

CreateArray(firstMartrix);
WriteLine($"\nfirst matrix:");
WriteArray(firstMartrix);
int[,] secondMartrix = new int[s, p];
CreateArray(secondMartrix);
WriteLine($"\nsecond matrix:");
WriteArray(secondMartrix);
int[,] resultMatrix = new int[m, p];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
WriteLine($"\nУмножение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}
