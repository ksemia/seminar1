// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

int ReadFromConsole (string message)
{
    Console.WriteLine("Введите размер массива");
    return int.Parse(Console.ReadLine());}
    int[] FillArray(int size)
    {
        int [] array = new int [size];
        for(int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(100,300);
        return array;
        }
        void PrintArray(int[]array)
        {
            for (int i = 0; i < array.Length; i ++ )
            Console.Write(array[i] + " "); // получили массив с рандомными полож числами
        }
        int CheckPosNumb(int[]array) //создали новый метод поиска четных чисел
        {
            int count = 0;
            for (int i = 0; x < array.Length; i++)
            {
                if (array[i] % 2 == 0; count++)
            }
                return i;
        }
            
            int size = ReadFromConsole ("Enter array size");
            int [] array = FillArray(size);
            PrintArray(array);

            int numb = CheckPosNumb(array);
            if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4){
                Console.WriteLine($"В массиве {count} четных числа");
            }
            else
            Console.WriteLine($"В массиве {count} четных чисел");
        



