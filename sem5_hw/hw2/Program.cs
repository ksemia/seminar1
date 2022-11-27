// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomOfNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

int sum = 0;
for (int x = 0; x < numbers.Length; x +=2)
{
    sum = sum + numbers[x];
    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов, стоящих на нечётных позициях = {sum}");
}
void FillArrayRandomOfNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
    Write("]");
    Console.WriteLine();
}
