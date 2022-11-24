// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;

Console.WriteLine("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int x = a;

for (int i = 1; i < b; i++){
    x = x*a;
}
Console.WriteLine("a в степени b равно: " + x);