// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using static System.Console;
Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

double min = Int32.MinValue; // double min - вещественный мин элемент массива
double max = Int32.MaxValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max); max = numbers[x];

    if (numbers[x] < min); min = numbers[x];
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимум = {max}, минимум = {min}");
Console.WriteLine($"Разница = {max - min}");  

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1,50));
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}