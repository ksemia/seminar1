// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//вещественные - double
// решение по лекции, есть ошибка в преобразованиях, но не понимаю как исправить

using static System.Console;
Clear();

double[,]GetArray(double m, double n)
{
    double[,]result = new double[m,n];
    for(int i =0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=Convert.ToDouble(new Random().Next(-10,10));
        }
    }
    return result;
}
void PrintArray(double[,]inArray)
{
    for(int i =0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}
Console.Write("введите кол-во строк: ");
int rows = Convert.ToInt32(ReadLine()!);
Console.Write("введите кол-во столбцов: ");
int cols = Convert.ToInt32(ReadLine()!);
double[,]array = GetArray(rows,cols);
PrintArray(array);

